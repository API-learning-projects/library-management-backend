using LibraryManagement.DTO;
using LibraryManagement.Data;
using LibraryManagement.Data.Models;

namespace LibraryManagement.Services
{
    public class GenreService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public GenreService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public List<GenreOutgoingDTO> GetAll()
        {
            List<GenreModel> genres = applicationDbContext.Genres.ToList();

            List<GenreOutgoingDTO> genreDTOs = new();
            foreach (GenreModel genre in genres)
            {
                genreDTOs.Add(new GenreOutgoingDTO(genre.Name));
            }

            return genreDTOs;
        }
    }
}