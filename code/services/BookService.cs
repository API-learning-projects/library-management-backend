using LibraryManagement.DTO;

namespace LibraryManagement.Services
{
    public class BookService
    {        
        public List<BookDTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public BookDTO GetById(int id)
        {
            return new BookDTO(id);
        }
    }
}