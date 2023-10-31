using LibraryManagement.DTO;
using LibraryManagement.Data;
using LibraryManagement.Data.Models;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class AuthorService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AuthorService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public List<AuthorDTO> GetAll()
        {
            List<AuthorModel> authors = applicationDbContext.Authors.ToList();

            List<AuthorDTO> authorDTOs = new();
            foreach (AuthorModel author in authors)
            {
                authorDTOs.Add(new AuthorDTO(author.Name));
            }

            return authorDTOs;
        }

        public AuthorDTO GetById(int id)
        {
            AuthorModel author = applicationDbContext.Authors.Find(id) ?? throw new BadHttpRequestException("Author does not exist");
            return new AuthorDTO(author.Name);
        }
    }
}