using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services.Book;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers.Book
{
    [ApiController]
    [Route("book/[controller]")]
    public class BuyController : ControllerUtils
    {
        private readonly BuyService bookService;

        public BuyController(BuyService buyService)
        {
            this.bookService = buyService;
        }

        [HttpGet]
        public IActionResult GetUserBoughtBooks()
        {
            string? authentication = Request.Headers["Authorization"];

            return RunLogic(() => {
                List<BookOutgoingDTO> books = bookService.GetUserBoughtBooks(authentication);
                return Ok(books);
            });
        }

        [HttpPost("{id}")]
        public IActionResult BuyBook(int id)
        {
            string? authentication = Request.Headers["Authorization"];

            return RunLogic(() => {
                bookService.BuyBook(id, authentication);
                return Ok();
            });
        }
    }
}