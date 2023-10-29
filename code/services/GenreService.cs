using LibraryManagement.DTO;
using LibraryManagement.Data;
using LibraryManagement.Data.Models;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class GenreService
    {
        private readonly ApplicationDbContext applicationDbContext = new();

        public List<GenreDTO> GetAll()
        {
            List<GenreModel> genres = applicationDbContext.Genres.ToList();

            List<GenreDTO> genreDTOs = new();
            foreach (GenreModel genre in genres)
            {
                genreDTOs.Add(new GenreDTO(genre.Name));
            }

            return genreDTOs;
        }
    }
}