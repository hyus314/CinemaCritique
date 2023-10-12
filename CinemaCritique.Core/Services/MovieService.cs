﻿using CinemaCritique.Core.Contracts;
using CinemaCritique.Data;
using CinemaCritique.Security;
using CinemaCritique.ViewModels.Movie;
using Microsoft.EntityFrameworkCore;

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
                switch (filters["rating"])
                {
                    case "unrated":
                        moviesQuery = moviesQuery
                            .Where(x => x.Reviews.Count == 0);
                        break;
                    case "desc":
                        moviesQuery = moviesQuery
                         .Where(x => x.Reviews.Count > 0)
                         .OrderByDescending(x => x.Reviews.Average(r => r.Rating)); 
                        break;
                    case "asc":
                        moviesQuery = moviesQuery
                        .Where(x => x.Reviews.Count > 0)
                        .OrderBy(x => x.Reviews.Average(r => r.Rating));
                        break;
                    default:
                        break;
                }
            }

            var movies = await moviesQuery
                .AsNoTracking()
                .Select(x => new AllMovieViewModel()
                {
                    Id = dataProtector.Encrypt(x.Id),
                    CoverPhotoURL = x.CoverPhotoURL,
                    Rating = x.Reviews.Count > 0 ?Math.Round(x.Reviews.Average(x => x.Rating), 1).ToString() + " ☆" : "",
                    Title = x.Title,
                    YearPublished = x.YearPublished.ToString()
                })
                .Skip((page - 1) * 10)
                .Take(10)
                .ToArrayAsync();

            return movies;
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

            if (!model.IsValid())
            {
                throw new InvalidOperationException("This movie has an invalid state!");
            }

            return model;
        }
    }
}
