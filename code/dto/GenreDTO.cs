namespace LibraryManagement.DTO
{
    public class GenreDTO
    {
        public string Genre { get; set; }
        public GenreDTO(string genre)
        {
            this.Genre = genre;
        }
    }
}