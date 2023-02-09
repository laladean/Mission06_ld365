﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_ld365.Models;

namespace Mission06_ld365.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230209012746_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_ld365.Models.MovieEntry", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Drama",
                            Director = "Morten Tyldum",
                            Edited = false,
                            LentTo = "No one",
                            Notes = "Love cumberbatch",
                            Rating = "PG-13",
                            Title = "Imitation Game",
                            Year = "2014"
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Comedy",
                            Director = "Nathan Greno, Bryon Howard",
                            Edited = false,
                            LentTo = "No one",
                            Notes = "fav movie of all time",
                            Rating = "PG",
                            Title = "Tangled",
                            Year = "2010"
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Action/Adventure",
                            Director = "Anothony Russo, Joe Russo",
                            Edited = false,
                            LentTo = "No one",
                            Notes = "gotta love cap",
                            Rating = "PG-13",
                            Title = "Captain America: The Winter Soldier",
                            Year = "2014"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}