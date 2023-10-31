using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Models
{
    public class AccountModel
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        
        public AccountModel(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}