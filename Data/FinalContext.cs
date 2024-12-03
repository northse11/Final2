using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace Final.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext (DbContextOptions<FinalContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { ID = 1, FirstName = "Steve", LastName = "North", Birthdate = new DateTime(2004, 08, 11), Program = "Software", Year = "junior" },
                new TeamMember { ID = 2, FirstName = "Jack", LastName = "Cooper", Birthdate = new DateTime(2003, 06, 17), Program = "IT", Year = "test" },
                new TeamMember { ID = 3, FirstName = "Isan", LastName = "Kalhan", Birthdate = new DateTime(2015, 12, 31), Program = "test", Year = "test" },
                new TeamMember { ID = 4, FirstName = "Earl", LastName = "Schreck", Birthdate = new DateTime(2003, 08, 14), Program = "IT", Year = "Junior" },
                new TeamMember { ID = 5, FirstName = "Jon", LastName = "Soriano Sanjuan", Birthdate = new DateTime(2000, 05, 11), Program = "Software", Year = "Junior" }
                );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyID = 1, HobbyName = "Hobby", HobbyDescription = "Hobby....", HobbyAge = new DateTime(2015, 12, 31), HobbyActive = true, HobbyDifficulty = "test" },
                new Hobby { HobbyID = 2, HobbyName = "Marching Band", HobbyDescription = "Playing the trumpet for the University of Cincinnati Marching Band.", HobbyAge = new DateTime(2022, 8, 01), HobbyActive = true, HobbyDifficulty = "Medium" },
                new Hobby { HobbyID = 3, HobbyName = "Cooking", HobbyDescription = "Learning new recipes and cooking new foods", HobbyAge = new DateTime(2020, 10, 10), HobbyActive = true, HobbyDifficulty = "Medium" },
                new Hobby { HobbyID = 4, HobbyName = "Playing Piano", HobbyDescription = "Playing classical piano music", HobbyAge = new DateTime(2010, 01, 10), HobbyActive = false, HobbyDifficulty = "Medium" },
                new Hobby { HobbyID = 5, HobbyName = "hobby", HobbyDescription = "hobby...", HobbyAge = new DateTime(2010, 01, 10), HobbyActive = true, HobbyDifficulty = "test" }
                );

            modelBuilder.Entity<FavoriteSong>().HasData(
                new FavoriteSong { FavoriteSongID = 1, TeamMemberID = 4, SongName = "Bohemian Rhapsody", Artist = "Queen" },
                new FavoriteSong { FavoriteSongID = 2, TeamMemberID = 2, SongName = "Invisible", Artist = "Duran Duran" },
                new FavoriteSong { FavoriteSongID = 3, TeamMemberID = 1, SongName = "Lyin' Eyes", Artist = "Eagles" },
                new FavoriteSong { FavoriteSongID = 4, TeamMemberID = 5, SongName = "Wildfire", Artist = "Black Out The Sun" },
                new FavoriteSong { FavoriteSongID = 5, TeamMemberID = 3, SongName = "test", Artist = "test" }
                );
            modelBuilder.Entity<FavoriteMovie>().HasData(
                new FavoriteMovie { ID = 1, Title = "Inception", Director = "Christopher Nolan", ReleaseDate = new DateTime(2010, 7, 16), Genre = "Sci-Fi", Rating = 8.8 },
                new FavoriteMovie { ID = 2, Title = "Star Wars: Episode V - The Empire Strikes Back", Director = "Irvin Kershner", ReleaseDate = new DateTime(1980, 5, 06), Genre = "Sci-Fi", Rating = 8.7 },
                new FavoriteMovie { ID = 3, Title = "Signs", Director = "M Night Shyamalan", ReleaseDate = new DateTime(2002, 08, 02), Genre = "Sci-Fi", Rating = 10 },
                new FavoriteMovie { ID = 4, Title = "Smile 2", Director = "Parker Finn", ReleaseDate = new DateTime(2024, 10, 24), Genre = "Horror", Rating = 8.5 },
                new FavoriteMovie { ID = 5, Title = "test", Director = "test", ReleaseDate = new DateTime(2024, 10, 24), Genre = "test", Rating = 8.5 }
                );
            modelBuilder.Entity<BreakfastItems>().HasData(
                new BreakfastItems { breakfastID = 1, breakfastItemName = "Waffles", breakfastItemDescription = "Chocolate Chip Waffles and Syrup", breakfastItemPrice = 10, breakfastItemQuantity = 2, breakfastTime = new DateTime(2024, 10, 24) },
                new BreakfastItems { breakfastID = 2, breakfastItemName = "Bacon Cheese McGriddle", breakfastItemDescription = "God's Gift to the World", breakfastItemPrice = 4, breakfastItemQuantity = 2, breakfastTime = new DateTime(2024, 12, 06) },
                new BreakfastItems { breakfastID = 3, breakfastItemName = "test", breakfastItemDescription = "test", breakfastItemPrice = 1, breakfastItemQuantity = 1, breakfastTime = new DateTime(2024, 10, 24) },
                new BreakfastItems { breakfastID = 4, breakfastItemName = "test", breakfastItemDescription = "test", breakfastItemPrice = 1, breakfastItemQuantity = 1, breakfastTime = new DateTime(2024, 10, 24) },
                new BreakfastItems { breakfastID = 5, breakfastItemName = "test", breakfastItemDescription = "test", breakfastItemPrice = 1, breakfastItemQuantity = 1, breakfastTime = new DateTime(2024, 10, 24) }
               );
        }

        public DbSet<Final.Models.TeamMember> TeamMember { get; set; } = default!;
        public DbSet<Final.Models.FavoriteMovie> FavoriteMovie { get; set; } = default!;
        public DbSet<Final.Models.Hobby> Hobby { get; set; } = default!;
        public DbSet<Final.Models.BreakfastItems> BreakfastItems { get; set; } = default!;
        public DbSet<Final.Models.FavoriteSong> FavoriteSong { get; set; } = default!;
    }
}
