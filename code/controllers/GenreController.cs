using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly GenreService genreService = new();

        [HttpGet]
        public IActionResult Get()
        {
            List<GenreDTO> authors = genreService.GetAll();
            return Ok(authors);
        }
    }
}