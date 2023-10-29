using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services.Book;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers.Book
{
    [ApiController]
    [Route("book/[controller]")]
    public class SellController : ControllerUtils
    {
        private readonly SellService bookService = new();

        [HttpGet]
        public IActionResult GetUserSoldBooks()
        {
            string? authentication = Request.Headers["Authorization"];

            return RunLogic(() => {
                List<BookDTO> books = bookService.GetUserSoldBooks(authentication);
                return Ok(books);
            });
        }

        [HttpPost("{id}")]
        public IActionResult SellBook(int id)
        {
            string? authentication = Request.Headers["Authorization"];
            
            return RunLogic(() => {
                bookService.SellBook(id, authentication);
                return Ok();
            });
        }
    }
}
