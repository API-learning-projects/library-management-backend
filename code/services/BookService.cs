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

        public List<BookOutgoingDTO> GetAll(int page)
        {
            List<BookModel> books = applicationDbContext.Books
                .Skip(AMOUNT_PER_PAGE * page)
                .Take(AMOUNT_PER_PAGE)
                .ToList();

            List<BookOutgoingDTO> bookDTOs = new();
            foreach (BookModel book in books)
            {
                bookDTOs.Add(new BookOutgoingDTO(book.Title));
            }

            return bookDTOs;
        }

        public BookOutgoingDTO GetById(int id)
        {
            BookModel book = applicationDbContext.Books.Find(id) ?? throw new BadHttpRequestException("Book does not exist");
            return new BookOutgoingDTO(book.Title);
        }
    }
}