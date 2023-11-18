using LibraryManagement.DTO;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services.Book
{
    public class BorrowService
    {
        public List<BookOutgoingDTO> GetUserBorrowedBooks(string? authentication)
        {
            if (authentication == null) {
                throw new BadHttpRequestException("No authentication header found");
            }

            if (authentication.StartsWith("Bearer ") == false) {
                throw new BadHttpRequestException("Authentication header is not bearer");
            }

            return new List<BookOutgoingDTO>();
        }

        public void BorrowBook(int id, string? authentication)
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