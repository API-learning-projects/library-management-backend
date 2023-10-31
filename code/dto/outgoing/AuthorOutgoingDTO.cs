namespace LibraryManagement.DTO
{
    public class AuthorOutgoingDTO
    {
        public string Name { get; set; }

        public AuthorOutgoingDTO(string name)
        {
            Name = name;
        }
    }
}