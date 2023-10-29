using LibraryManagement.DTO;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services.Book
{
    public class SellService
    {
        public List<BookDTO> GetUserSoldBooks(string? authentication)
        {
            if (authentication == null) {
                throw new BadHttpRequestException("No authentication header found");
            }

            if (authentication.StartsWith("Bearer ") == false) {
                throw new BadHttpRequestException("Authentication header is not bearer");
            }

            return new List<BookDTO>();
        }
        
        public void SellBook(int id, string? authentication)
        {
            if (authentication == null) {
                throw new BadHttpRequestException("No authentication header found");
            }

            if (authentication.StartsWith("Bearer ") == false) {
                throw new BadHttpRequestException("Authentication header is not bearer");
            }
        }
    }
}