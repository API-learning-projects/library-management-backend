using LibraryManagement.DTO;
using LibraryManagement.Data;
using LibraryManagement.Data.Models;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class TestService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public TestService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public void Test()
        {
            // Add difficulties
            DifficultyModel easy = new()
            {
                Name = "Easy"
            };
            applicationDbContext.Difficulties.Add(easy);

            DifficultyModel medium = new()
            {
                Name = "Medium"
            };
            applicationDbContext.Difficulties.Add(medium);

            DifficultyModel hard = new()
            {
                Name = "Hard"
            };
            applicationDbContext.Difficulties.Add(hard);

            // Add genres
            GenreModel fantasy = new()
            {
                Name = "Fantasy"
            
            };
            applicationDbContext.Genres.Add(fantasy);

            GenreModel sciFi = new()
            {
                Name = "Sci-Fi"
            
            };
            applicationDbContext.Genres.Add(sciFi);

            GenreModel romance = new()
            {
                Name = "Romance"
            
            };
            applicationDbContext.Genres.Add(romance);

            GenreModel horror = new()
            {
                Name = "Horror"
            
            };
            applicationDbContext.Genres.Add(horror);

            // Add authors
            AuthorModel jkRowling = new()
            {
                Id = 1,
                Name = "J.K. Rowling"
            };
            applicationDbContext.Authors.Add(jkRowling);

            AuthorModel stephenKing = new()
            {
                Id = 2,
                Name = "Stephen King"
            };
            applicationDbContext.Authors.Add(stephenKing);

            AuthorModel jrrTolkien = new()
            {
                Id = 3,
                Name = "J.R.R. Tolkien"
            };
            applicationDbContext.Authors.Add(jrrTolkien);

            AuthorModel georgeOrwell = new()
            {
                Id = 4,
                Name = "George Orwell"
            };
            applicationDbContext.Authors.Add(georgeOrwell);

            // Add books
            BookModel harryPottah = new()
            {
                Id = 1,
                Title = "Harry Pottah 1",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 100,
                Difficulty = easy,
                BuyPrice = 100,
            };
            applicationDbContext.Books.Add(harryPottah);

            BookModel harryPottah2 = new()
            {
                Id = 2,
                Title = "Harry Pottah 2",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 200,
                Difficulty = medium,
                BorrowPrice = 200,
            };
            applicationDbContext.Books.Add(harryPottah2);

            BookModel harryPottah3 = new()
            {
                Id = 3,
                Title = "Harry Pottah 3",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 300,
                Difficulty = hard,
                BuyPrice = 300,
            };
            applicationDbContext.Books.Add(harryPottah3);

            BookModel harryPottah4 = new()
            {
                Id = 4,
                Title = "Harry Pottah 4",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 400,
                Difficulty = easy,
                BorrowPrice = 400,
            };
            applicationDbContext.Books.Add(harryPottah4);

            BookModel harryPottah5 = new()
            {
                Id = 5,
                Title = "Harry Pottah 5",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 500,
                Difficulty = medium,
                BuyPrice = 500,
            };
            applicationDbContext.Books.Add(harryPottah5);

            BookModel harryPottah6 = new()
            {
                Id = 6,
                Title = "Harry Pottah 6",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 600,
                Difficulty = hard,
                BuyPrice = 600,
            };
            applicationDbContext.Books.Add(harryPottah6);

            BookModel harryPottah7 = new()
            {
                Id = 7,
                Title = "Harry Pottah 7",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 700,
                Difficulty = easy,
                BorrowPrice = 700,
            };
            applicationDbContext.Books.Add(harryPottah7);

            BookModel harryPottah8 = new()
            {
                Id = 8,
                Title = "Harry Pottah 8",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 800,
                Difficulty = medium,
                BuyPrice = 800,
            };
            applicationDbContext.Books.Add(harryPottah8);

            BookModel harryPottah9 = new()
            {
                Id = 9,
                Title = "Harry Pottah 9",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 900,
                Difficulty = hard,
                BuyPrice = 900,
            };
            applicationDbContext.Books.Add(harryPottah9);

            BookModel harryPottah10 = new()
            {
                Id = 10,
                Title = "Harry Pottah 10",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 1000,
                Difficulty = easy,
                BorrowPrice = 1000,
            };
            applicationDbContext.Books.Add(harryPottah10);

            BookModel harryPottah11 = new()
            {
                Id = 11,
                Title = "Harry Pottah 11",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 1100,
                Difficulty = medium,
                BuyPrice = 1100,
            };
            applicationDbContext.Books.Add(harryPottah11);

            BookModel harryPottah12 = new()
            {
                Id = 12,
                Title = "Harry Pottah 12",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 1200,
                Difficulty = hard,
                BuyPrice = 1200,
            };
            applicationDbContext.Books.Add(harryPottah12);

            BookModel harryPottah13 = new()
            {
                Id = 13,
                Title = "Harry Pottah 13",
                Genre = fantasy,
                Author = jkRowling,
                Duration = 1300,
                Difficulty = easy,
                BorrowPrice = 1300,
            };
            applicationDbContext.Books.Add(harryPottah13);

            applicationDbContext.SaveChanges();
        }
    }
}