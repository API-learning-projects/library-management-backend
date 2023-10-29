namespace LibraryManagement.DTO
{
    public class AuthorDTO
    {
        public string Name { get; set; }

        public AuthorDTO(string name)
        {
            Name = name;
        }
    }
}