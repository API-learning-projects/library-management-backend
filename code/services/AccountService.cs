using LibraryManagement.DTO;
using LibraryManagement.Data;
using LibraryManagement.Data.Models;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class AccountService
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly JWTService jwtService;
        private readonly BCryptService bCryptService;

        public AccountService(ApplicationDbContext applicationDbContext, JWTService jwtService, BCryptService bCryptService) {
            this.applicationDbContext = applicationDbContext;
            this.jwtService = jwtService;
            this.bCryptService = bCryptService;
        }

        public AccountOutgoingDTO Login(string? authorization)
        {
            if (authorization == null) {
                throw new BadHttpRequestException("No authorization header found");
            }

            if (authorization.StartsWith("Basic ") == false) {
                throw new BadHttpRequestException("Authorization header is not basic");
            }

            string usernameAndPassword = authorization.Substring("Basic ".Length).Trim();
            string[] parts = usernameAndPassword.Split(':');

            if (parts.Length != 2) {
                throw new BadHttpRequestException("Invalid authorization header");
            }

            string username = parts[0];
            string password = parts[1];

            AccountModel account = applicationDbContext.Accounts.Find(username) ?? throw new BadHttpRequestException("Invalid username or password");

            if (bCryptService.Check(password, account.Password) == false) {
                throw new BadHttpRequestException("Invalid username or password");
            }

            string token = jwtService.GenerateToken(account.Username);

            return new AccountOutgoingDTO(token);
        }

        public void Register(string username, string password, string email)
        {
            if (applicationDbContext.Accounts.Find(username) != null) {
                throw new BadHttpRequestException("Username already exists");
            }

            string hashedPassword = bCryptService.Hash(password);

            AccountModel account = new()
            {
                Username = username,
                Password = hashedPassword,
                Email = email
            };
            applicationDbContext.Accounts.Add(account);
            applicationDbContext.SaveChanges();
        }
    }
}