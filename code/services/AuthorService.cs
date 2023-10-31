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

        public List<AuthorOutgoingDTO> GetAll()
        {
            List<AuthorModel> authors = applicationDbContext.Authors.ToList();

            List<AuthorOutgoingDTO> authorDTOs = new();
            foreach (AuthorModel author in authors)
            {
                authorDTOs.Add(new AuthorOutgoingDTO(author.Name));
            }

            return authorDTOs;
        }

        public AuthorOutgoingDTO GetById(int id)
        {
            AuthorModel author = applicationDbContext.Authors.Find(id) ?? throw new BadHttpRequestException("Author does not exist");
            return new AuthorOutgoingDTO(author.Name);
        }
    }
}