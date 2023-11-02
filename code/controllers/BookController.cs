using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerUtils
    {
        private readonly BookService bookService;

        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBooks([FromQuery] int page)
        {
            return RunLogic(() => {
                List<BookOutgoingDTO> books = bookService.GetAll(page);
                return Ok(books);
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            return RunLogic(() => {
                BookOutgoingDTO book = bookService.GetById(id);
                return Ok(book);
            });
        }
    }
}
