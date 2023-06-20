using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-01-30"),
                        Genre = "Comedy",
                        Price = 2.15M,
                        Rating = "PG",
                        imageURL = "https://image.tmdb.org/t/p/w500/A1l7mSbptwFdutUbOq4zzhH4goa.jpg"
                    },
                    new Movie
                    {
                        Title = "The Singles 2nd Ward",
                        ReleaseDate = DateTime.Parse("2007-12-11"),
                        Genre = "Comedy",
                        Price = 5.55M,
                        Rating = "PG",
                        imageURL = "https://image.tmdb.org/t/p/w500/ujCtMl8ncRTBHCis4V92jhYyhUW.jpg"
                    },
                    new Movie
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-01-24"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG",
                        imageURL = "https://image.tmdb.org/t/p/w500/OQ3X7k13koP833iZx1PRIPngZ8.jpg"
                    },
                    new Movie
                    {
                        Title = "Saints and Soldiers",
                        ReleaseDate = DateTime.Parse("2003-09-11"),
                        Genre = "Action",
                        Price = 19.99M,
                        Rating = "PG-13",
                        imageURL = "https://image.tmdb.org/t/p/w500/A4LgmMTiRpkEzC6pxRcxE28IDov.jpg"
                    },
                    new Movie
                    {
                        Title = "Midway to Heaven",
                        ReleaseDate = DateTime.Parse("2011-02-04"),
                        Genre = "Mystery",
                        Price = 6.99M,
                        Rating = "PG",
                        imageURL = "https://image.tmdb.org/t/p/w500/zHI3xAxLlq7BqHdqD9euyfSwnrf.jpg"
                    },
                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-02-20"),
                        Genre = "Comedy",
                        Price = 4.99M,
                        Rating = "PG",
                        imageURL = "https://image.tmdb.org/t/p/w500/regPVSdn7PUJmY7vWc6n4Qjsb4q.jpg"
                    }
            );
            context.SaveChanges();
        }
    }
}