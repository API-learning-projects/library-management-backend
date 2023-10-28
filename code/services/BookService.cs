using LibraryManagement.DTO;

namespace LibraryManagement.Services
{
    public class BookService
    {        
        public List<BookDTO> GetAll()
        {
            List<BookDTO> books = new()
            {
                new BookDTO(1),
                new BookDTO(2),
                new BookDTO(3),
                new BookDTO(4),
            };
            return books;
        }

        public BookDTO GetById(int id)
        {
            return new BookDTO(id);
        }
    }
}