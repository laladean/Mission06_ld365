using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_ld365.Models
{
    public class MovieContext : DbContext
    {
        //constructor
        public  MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<MovieEntry> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public object Responses { get; internal set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            //seeding the category database/table
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure"},
                new Category { CategoryID = 2, CategoryName = "Comedy"},
                new Category { CategoryID = 3, CategoryName = "Drama"},
                new Category { CategoryID = 4, CategoryName = "Family"},
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense"},
                new Category { CategoryID = 6, CategoryName = "Miscellaneous"},
                new Category { CategoryID = 7, CategoryName = "Television"},
                new Category { CategoryID = 8, CategoryName = "VHS"}
                );

            //seeding the database
            mb.Entity<MovieEntry>().HasData(
                new MovieEntry
                {
                    MovieId = 1,
                    CategoryID = 3,
                    Title = "Imitation Game",
                    Year = "2014",
                    Director = "Morten Tyldum",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo ="No one",
                    Notes = "Love cumberbatch"


                },
                new MovieEntry
                {
                    MovieId = 2,
                    CategoryID = 2,
                    Title = "Tangled",
                    Year = "2010",
                    Director = "Nathan Greno, Bryon Howard",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "No one",
                    Notes = "fav movie of all time"
                },
                new MovieEntry
                {
                    MovieId = 3,
                    CategoryID = 1,
                    Title = "Captain America: The Winter Soldier",
                    Year = "2014",
                    Director = "Anothony Russo, Joe Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "No one",
                    Notes = "gotta love cap"
                });
        }
    }
}
