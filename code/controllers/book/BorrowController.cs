using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services.Book;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers.Book
{
    [ApiController]
    [Route("book/[controller]")]
    public class BorrowController : ControllerUtils
    {
        private readonly BorrowService bookService = new();

        [HttpGet]
        public IActionResult GetUserBorrowedBooks()
        {
            string? authentication = Request.Headers["Authorization"];

            return RunLogic(() => {
                List<BookDTO> books = bookService.GetUserBorrowedBooks(authentication);
                return Ok(books);
            });
        }

        [HttpPost("{id}")]
        public IActionResult BorrowBook(int id)
        {
            string? authentication = Request.Headers["Authorization"];

            return RunLogic(() => {
                bookService.BorrowBook(id, authentication);
                return Ok();
            });
        }
    }
}