using BC = BCrypt.Net.BCrypt;

namespace LibraryManagement.Services
{
    public class BCryptService
    {
        public string Hash(string password)
        {
            return BC.HashPassword(password);
        }

        public bool Check(string password, string hashedPassword)
        {
            return BC.Verify(password, hashedPassword);
        }
    }
}