using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services.Book;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers.Book
{
    [ApiController]
    [Route("book/[controller]")]
    public class SellController : ControllerUtils
    {
        private readonly SellService bookService;

        public SellController(SellService sellService)
        {
            this.bookService = sellService;
        }

        [HttpGet]
        public IActionResult GetUserSoldBooks()
        {
            string? authentication = Request.Headers["Authorization"];

            return RunLogic(() => {
                List<BookOutgoingDTO> books = bookService.GetUserSoldBooks(authentication);
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
