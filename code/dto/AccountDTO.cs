namespace LibraryManagement.DTO
{
    public class AccountDTO
    {
        public string Token { get; set; }
        public AccountDTO(string token)
        {
            Token = token;
        }
    }
}