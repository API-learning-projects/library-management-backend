using LibraryManagement.DTO;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class AccountService
    {
        public AccountDTO Login(string? authorization)
        {
            if (authorization == null) {
                throw new BadHttpRequestException("No authorization header found");
            }

            if (authorization.StartsWith("Basic ") == false) {
                throw new BadHttpRequestException("Authorization header is not basic");
            }

            return new AccountDTO("Token");
        }

        public void Register()
        {
        }
    }
}