namespace LibraryManagement.DTO
{
    public class RegisterIncomingDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email {get; set;}

        public RegisterIncomingDTO(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}