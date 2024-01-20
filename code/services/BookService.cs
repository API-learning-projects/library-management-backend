using LibraryManagement.DTO;
using LibraryManagement.Data;
using LibraryManagement.Data.Models;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class BookService
    {
        private readonly int AMOUNT_PER_PAGE = 10;

        private readonly ApplicationDbContext applicationDbContext;

        public BookService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public List<BookMultipleOutgoingDTO> GetAll(int page, string? genre, string? author, int? duration, string? difficulty)
        {
            List<BookModel> books = applicationDbContext.Books
                .Where(book => genre == null || book.Genre.Name == genre)
                .Where(book => author == null || book.Author.Name == author)
                .Where(book => duration == null || book.Duration == duration)
                .Where(book => difficulty == null || book.Difficulty.Name == difficulty)
                .Skip(AMOUNT_PER_PAGE * (page - 1))
                .Take(AMOUNT_PER_PAGE)
                .ToList();


            List<BookMultipleOutgoingDTO> bookDTOs = new();
            foreach (BookModel book in books)
            {
                bookDTOs.Add(new BookMultipleOutgoingDTO(book.Title, book.Author.Name, book.Genre.Name, book.Difficulty.Name, book.Duration));
            }

            return bookDTOs;
        }

        public BookOutgoingDTO GetById(int id)
        {
            BookModel book = applicationDbContext.Books.Find(id) ?? throw new BadHttpRequestException("Book does not exist");
            return new BookOutgoingDTO(book.Title, book.Author.Name, book.Genre.Name, book.Difficulty.Name, book.Duration, book.BuyPrice, book.BorrowPrice);
        }
    }
}