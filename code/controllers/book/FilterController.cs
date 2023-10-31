using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services.Book;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers.Book
{
    [ApiController]
    [Route("[controller]")]
    public class FilterController : ControllerUtils
    {
        private readonly FilterService filterService;

        public FilterController(FilterService filterService)
        {
            this.filterService = filterService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return RunLogic(() => {
                List<BookDTO> filters = filterService.GetBooks();
                return Ok(filters);
            });
        }
    }
}