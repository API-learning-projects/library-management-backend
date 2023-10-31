using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerUtils
    {
        private readonly AuthorService authorService;

        public AuthorController(AuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return RunLogic(() => {
                List<AuthorOutgoingDTO> authors = authorService.GetAll();
                return Ok(authors);
            });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return RunLogic(() => {
                AuthorOutgoingDTO author = authorService.GetById(id);
                return Ok(author);
            });
        }
    }
}