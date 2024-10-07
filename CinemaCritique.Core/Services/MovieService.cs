using CinemaCritique.Core.Contracts;
using CinemaCritique.Data;
using CinemaCritique.Data.Models;
using CinemaCritique.Security;
using CinemaCritique.ViewModels.Movie;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace CinemaCritique.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly CritiqueDbContext data;
        private readonly MovieDataProtector dataProtector;

        public MovieService(CritiqueDbContext data, MovieDataProtector dataProtector)
        {
            this.data = data;
            this.dataProtector = dataProtector;
        }

        public async Task<ICollection<RecentMovieViewModel>> GetMostRecentFilmsAsync()
        {
            ICollection<RecentMovieViewModel> model = new HashSet<RecentMovieViewModel>();

            if (this.data.Movies.Count() >= 5)
            {
                model = await this.data.Movies
                   .AsNoTracking()
                   .OrderByDescending(x => x.DateAdded)
                   .Select(x => new RecentMovieViewModel()
                   {
                       Id = this.dataProtector.Encrypt(x.Id),
                       CoverPhotoURL = x.CoverPhotoURL,
                       ScenePhotoURL = x.ScenePhotoUrl,
                       Title = x.Title,
                       TrailerURL = x.TrailerURL
                   })
                   .Take(5)
                   .ToArrayAsync();
            }
            else
            {
                model = await this.data.Movies
                   .AsNoTracking()
                   .OrderByDescending(x => x.DateAdded)
                   .Select(x => new RecentMovieViewModel()
                   {
                       Id = this.dataProtector.Encrypt(x.Id),
                       CoverPhotoURL = x.CoverPhotoURL,
                       ScenePhotoURL = x.ScenePhotoUrl,
                       Title = x.Title,
                       TrailerURL = x.TrailerURL
                   })
                   .ToArrayAsync();

            }
            return model;
        }

        public async Task<ICollection<AllMovieViewModel>> GetMoviesForAllPage(int page, Dictionary<string, string> filters)
        {
            var moviesQuery = this.data.Movies.AsQueryable();

            if (!string.IsNullOrEmpty(filters["search"]))
            {
                moviesQuery =  FilerMoviesBySearchTermAsync(filters["search"]);
            }

            switch (filters["date"])
            {
                case "new":
                    moviesQuery = moviesQuery.OrderByDescending(x => x.DateAdded);
                    break;

                case "old":
                    moviesQuery = moviesQuery.OrderBy(x => x.DateAdded);
                    break;
                default:
                    break;
            }

            if (!string.IsNullOrEmpty(filters["genre"]))
            {
                moviesQuery = moviesQuery.Where(x => x.Genre.Name == filters["genre"]);
            }

            if (!string.IsNullOrEmpty(filters["rating"]))
            {
                moviesQuery = FilterMoviesByRating(filters, moviesQuery);
            }

            var movies = await moviesQuery
                .AsNoTracking()
                .Select(x => new AllMovieViewModel()
                {
                    Id = dataProtector.Encrypt(x.Id),
                    CoverPhotoURL = x.CoverPhotoURL,
                    Rating = x.Reviews.Count > 0 ? Math.Round(x.Reviews.Average(x => x.Rating), 1).ToString() + " ☆" : "",
                    Title = x.Title,
                    YearPublished = x.YearPublished.ToString()
                })
                .Skip((page - 1) * 10)
                .Take(10)
                .ToArrayAsync();

            return movies;
        }

        private static IQueryable<Movie> FilterMoviesByRating(Dictionary<string, string> filters, IQueryable<Movie> moviesQuery)
        {
            switch (filters["rating"])
            {
                case "unrated":
                    moviesQuery = moviesQuery
                        .Where(x => x.Reviews.Count == 0);
                    break;
                case "desc":
                    if (filters["date"] == "new")
                    {
                        moviesQuery = moviesQuery
                         .Where(x => x.Reviews.Count > 0)
                         .OrderByDescending(x => x.Reviews.Average(r => r.Rating))
                         .ThenByDescending(x => x.DateAdded);
                    }
                    else
                    {
                        moviesQuery = moviesQuery
                        .Where(x => x.Reviews.Count > 0)
                        .OrderByDescending(x => x.Reviews.Average(r => r.Rating))
                        .ThenBy(x => x.DateAdded);
                    }
                    break;
                case "asc":
                    if (filters["date"] == "new")
                    {
                        moviesQuery = moviesQuery
                         .Where(x => x.Reviews.Count > 0)
                         .OrderBy(x => x.Reviews.Average(r => r.Rating))
                         .ThenByDescending(x => x.DateAdded);
                    }
                    else
                    {
                        moviesQuery = moviesQuery
                        .Where(x => x.Reviews.Count > 0)
                        .OrderBy(x => x.Reviews.Average(r => r.Rating))
                        .ThenBy(x => x.DateAdded);
                    }
                    break;
                default:
                    break;
            }

            return moviesQuery;
        }

        private  IQueryable<Movie> FilerMoviesBySearchTermAsync(string searchTerm)
        {
            var moviesQuery = data.Movies.AsQueryable();

            if (string.IsNullOrWhiteSpace(searchTerm))
                return moviesQuery;

            searchTerm = searchTerm.ToLower();

            moviesQuery = moviesQuery.Where(x =>
                x.Director.ToLower().Contains(searchTerm) ||
                x.MainRoles.ToLower().Contains(searchTerm) ||
                x.Title.ToLower().Contains(searchTerm));

            return moviesQuery;
        }

        public async Task<ICollection<HomePageMovieViewModel>> GetMoviesForHomePageAsync()
        {
            var model = await this.data.Movies
               .AsNoTracking()
               .OrderBy(r => Guid.NewGuid())
               .Select(x => new HomePageMovieViewModel()
               {
                   Id = this.dataProtector.Encrypt(x.Id),
                   Title = x.Title,
                   CoverPhotoUrl = x.CoverPhotoURL
               })
               .Take(10)
               .ToArrayAsync();

            return model;
        }

        public async Task<SelectedMovieViewModel> GetSelectedMoviePageAsync(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Such movie does not exist!");
            }

            var decryptedId = this.dataProtector.Decrypt(id);

            var entity = await this.data.Movies.FindAsync(decryptedId);

            var genre = await this.data.Genres.FindAsync(entity!.GenreId);

            if (entity == null)
            {
                throw new ArgumentNullException("There is no movie with this id!");
            }

            string rating;
            bool hasReviews = false;
            var reviewsOfEntity = await this.data.Reviews.Where(x => x.MovieId == decryptedId).ToListAsync();
            if (reviewsOfEntity.Count > 0)
            {
                rating = Math.Round(entity.Reviews.Average(x => x.Rating), 1).ToString() + "/10";
                hasReviews = true;
            }
            else
            {
                rating = "This movie is yet to be reviewed!";
            }

            var model = new SelectedMovieViewModel()
            {
                Id = dataProtector.Encrypt(entity.Id),
                Title = entity.Title,
                Director = entity.Director,
                Description = entity.Description,
                YearPublished = entity.YearPublished.ToString(),
                CoverPhotoURL = entity.CoverPhotoURL,
                Rating = rating,
                TrailerURL = entity.TrailerURL,
                Genre = genre!.Name,
                ScenePhotoURL = entity.ScenePhotoUrl,
                MainRoles = entity.MainRoles,
                HasReviews = hasReviews
            };

            if (!IsMovieValid(model))
            {
                throw new InvalidOperationException("This movie has an invalid state!");
            }

            return model;
        }
        
        
        private bool IsMovieValid(SelectedMovieViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Title)) return false;
            if (string.IsNullOrWhiteSpace(model.Director)) return false;
            if (string.IsNullOrWhiteSpace(model.Description)) return false;
            if (string.IsNullOrWhiteSpace(model.YearPublished)) return false;
            if (!int.TryParse(model.YearPublished, out int year) || year < 1888 || year > DateTime.Now.Year) return false;
            if (string.IsNullOrWhiteSpace(model.Genre)) return false;
            if (string.IsNullOrWhiteSpace(model.MainRoles)) return false;

            if (!string.IsNullOrWhiteSpace(model.TrailerURL) && !Uri.IsWellFormedUriString(model.TrailerURL, UriKind.Absolute)) return false;

            if (string.IsNullOrWhiteSpace(model.CoverPhotoURL)) return false;
            if (string.IsNullOrWhiteSpace(model.ScenePhotoURL)) return false;

            return true;
        }
    }
}
