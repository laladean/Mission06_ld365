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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //seeding the database
            mb.Entity<MovieEntry>().HasData(
                new MovieEntry
                {
                    MovieId = 1,
                    Category = "Drama",
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
                    Category = "Comedy",
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
                    Category = "Action/Adventure",
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
