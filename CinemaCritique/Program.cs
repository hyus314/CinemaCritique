namespace CinemaCritique
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.Core.Services;
    using CinemaCritique.Data;
    using CinemaCritique.Data.Models;
    using CinemaCritique.Security;
    using Microsoft.AspNetCore.DataProtection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<CritiqueDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddSingleton(provider =>
            {
                var dataProtectionProvider = provider.GetService<IDataProtectionProvider>();
                return dataProtectionProvider.CreateProtector("ProtectMovieData");
            });

            builder.Services.AddSingleton<MovieDataProtector>();

            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddScoped<IReviewService, ReviewService>();

            builder.Services.AddDefaultIdentity<CritiqueUser>(opt =>
            {
                opt.SignIn.RequireConfirmedPhoneNumber = false;
                opt.SignIn.RequireConfirmedEmail = false;
                opt.Password.RequireDigit = true;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireUppercase = true;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<CritiqueDbContext>();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<CritiqueDbContext>();
                    context.Database.Migrate(); // apply all migrations

                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

                    if (!roleManager.RoleExistsAsync("Admin").Result)
                    {
                        var role = new IdentityRole("Admin");
                        var roleResult = roleManager.CreateAsync(role).Result;
                    }

                    if (!roleManager.RoleExistsAsync("User").Result)
                    {
                        var role = new IdentityRole("User");
                        var roleResult = roleManager.CreateAsync(role).Result;
                    }
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while migrating or initializing the database.");
                }
            }

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}