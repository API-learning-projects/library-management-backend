using LibraryManagement.DTO;
using LibraryManagement.Data.Models;
using LibraryManagement.Data.Repositories;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class BookService
    {
        public List<BookDTO> GetAll()
        {
            List<BookDTO> books = new()
            {
                new BookDTO("The Lord of the Rings"),
                new BookDTO("The Hobbit"),
            };
            return books;
        }

        public BookDTO GetById(int id)
        {
            return new BookDTO("The Lord of the Rings");
        }
    }
}