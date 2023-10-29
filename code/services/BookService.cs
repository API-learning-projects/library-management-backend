using LibraryManagement.DTO;
using LibraryManagement.Data;
using LibraryManagement.Data.Models;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class BookService
    {
        private readonly ApplicationDbContext applicationDbContext = new();

        public List<BookDTO> GetAll()
        {
            List<BookModel> books = applicationDbContext.Books.ToList();

            List<BookDTO> bookDTOs = new();
            foreach (BookModel book in books)
            {
                bookDTOs.Add(new BookDTO(book.Title));
            }

            return bookDTOs;
        }

        public BookDTO GetById(int id)
        {
            BookModel book = applicationDbContext.Books.Find(id) ?? throw new BadHttpRequestException("Book does not exist");
            return new BookDTO(book.Title);
        }
    }
}