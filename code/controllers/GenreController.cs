using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : ControllerUtils
    {
        private readonly GenreService genreService;

        public GenreController(GenreService genreService)
        {
            this.genreService = genreService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return RunLogic(() => {
                List<GenreDTO> genres = genreService.GetAll();
                return Ok(genres);
            });
        }
    }
}