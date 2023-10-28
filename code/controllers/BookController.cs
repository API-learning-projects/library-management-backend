using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookService bookService = new();

        [HttpGet]
        public IActionResult Get()
        {
            List<BookDTO> books = bookService.GetAll();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            BookDTO book = bookService.GetById(id);
            return Ok(book);
        }
    }
}
