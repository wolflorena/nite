﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nite.API.Data;

#nullable disable

namespace Nite.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230525185048_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Nite.API.Repository.Entities.Add", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TVShowId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TVShowId");

                    b.HasIndex("UserId");

                    b.ToTable("Added");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeasonId")
                        .HasColumnType("int");

                    b.Property<int>("TVShowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.HasIndex("TVShowId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.Favorites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TVShowId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TVShowId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DurationEpisode")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfEpisodes")
                        .HasColumnType("int");

                    b.Property<int>("TVShowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TVShowId");

                    b.ToTable("TVShowSeasons");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.TVShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Audience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewSeason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seasons")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Streaming")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TVShows");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Birthdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = "16.12.2001",
                            Email = "deeagabor@gmail.com",
                            Gender = "female",
                            IsAdmin = true,
                            Password = "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f",
                            Username = "deeagabor"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = "16.10.2001",
                            Email = "wolflorena@gmail.com",
                            Gender = "female",
                            IsAdmin = true,
                            Password = "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f",
                            Username = "wolflorena"
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = "10.10.2005",
                            Email = "testunu@gmail.com",
                            Gender = "male",
                            IsAdmin = false,
                            Password = "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f",
                            Username = "test1"
                        },
                        new
                        {
                            Id = 4,
                            Birthdate = "08.04.2011",
                            Email = "testdoi@gmail.com",
                            Gender = "male",
                            IsAdmin = false,
                            Password = "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f",
                            Username = "test2"
                        });
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.Watch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.Property<int>("SeasonId")
                        .HasColumnType("int");

                    b.Property<int>("TVShowId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EpisodeId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("TVShowId");

                    b.HasIndex("UserId");

                    b.ToTable("Watched");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.Add", b =>
                {
                    b.HasOne("Nite.API.Repository.Entities.TVShow", "TVShow")
                        .WithMany()
                        .HasForeignKey("TVShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nite.API.Repository.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TVShow");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.Episode", b =>
                {
                    b.HasOne("Nite.API.Repository.Entities.Season", "Season")
                        .WithMany("Episodes")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nite.API.Repository.Entities.TVShow", "TVShow")
                        .WithMany()
                        .HasForeignKey("TVShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");

                    b.Navigation("TVShow");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.Favorites", b =>
                {
                    b.HasOne("Nite.API.Repository.Entities.TVShow", "TVShow")
                        .WithMany()
                        .HasForeignKey("TVShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nite.API.Repository.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TVShow");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.Season", b =>
                {
                    b.HasOne("Nite.API.Repository.Entities.TVShow", "TVShow")
                        .WithMany("TVShowSeasons")
                        .HasForeignKey("TVShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TVShow");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.Watch", b =>
                {
                    b.HasOne("Nite.API.Repository.Entities.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nite.API.Repository.Entities.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nite.API.Repository.Entities.TVShow", "TVShow")
                        .WithMany()
                        .HasForeignKey("TVShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nite.API.Repository.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Episode");

                    b.Navigation("Season");

                    b.Navigation("TVShow");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.Season", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("Nite.API.Repository.Entities.TVShow", b =>
                {
                    b.Navigation("TVShowSeasons");
                });
#pragma warning restore 612, 618
        }
    }
}
