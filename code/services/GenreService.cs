using LibraryManagement.DTO;

namespace LibraryManagement.Services
{
    public class GenreService
    {
        public List<GenreDTO> GetAll()
        {
            List<GenreDTO> genres = new()
            {
                new GenreDTO("Fantasy"),
                new GenreDTO("Science Fiction"),
                new GenreDTO("Horror"),
                new GenreDTO("Thriller"),
                new GenreDTO("Mystery"),
                new GenreDTO("Historical Fiction"),
                new GenreDTO("Romance"),
                new GenreDTO("Western"),
                new GenreDTO("Dystopian"),
                new GenreDTO("Contemporary"),
                new GenreDTO("Memoir"),
                new GenreDTO("Cooking"),
                new GenreDTO("Art")
            };
            return genres;
        }
    }
}