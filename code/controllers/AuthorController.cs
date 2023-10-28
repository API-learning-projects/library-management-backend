using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService authorService = new();

        [HttpGet]
        public IActionResult Get()
        {
            List<AuthorDTO> authors = authorService.GetAll();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            AuthorDTO author = authorService.GetById(id);
            return Ok(author);
        }
    }
}