using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Pride and Predjudice: A Latter-Day Comedy",
                        Image = "~/Content/Images/Pridepredjudice.jpg",
                        ReleaseDate = DateTime.Parse("2003-12-05"),
                        Genre = "Romantic Comedy",
                        Rating = "PG",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        Image = "~/Content/Images/SinglesWard.jpg",
                        ReleaseDate = DateTime.Parse("2002-02-01"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "New York Doll",
                        Image = "~/Content/Images/NewYorkDoll.jpg",
                        ReleaseDate = DateTime.Parse("2005-10-28"),
                        Genre = "Documentary",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        Image = "~/Content/Images/17Miracles.jpg",
                        ReleaseDate = DateTime.Parse("2011-06-03"),
                        Genre = "Western",
                        Rating = "PG",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}