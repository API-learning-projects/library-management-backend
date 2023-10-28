using LibraryManagement.DTO;

namespace LibraryManagement.Services
{
    public class AuthorService
    {
        public List<AuthorDTO> GetAll()
        {
            List<AuthorDTO> authors = new()
            {
                new AuthorDTO(1),
                new AuthorDTO(2),
                new AuthorDTO(3),
                new AuthorDTO(4),
            };
            return authors;
        }

        public AuthorDTO GetById(int id)
        {
            return new AuthorDTO(id);
        }
    }
}