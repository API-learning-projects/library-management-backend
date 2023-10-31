namespace LibraryManagement.DTO
{
    public class AccountOutgoingDTO
    {
        public string Token { get; set; }
        public AccountOutgoingDTO(string token)
        {
            Token = token;
        }
    }
}