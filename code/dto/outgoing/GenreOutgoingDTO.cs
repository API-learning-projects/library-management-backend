namespace LibraryManagement.DTO
{
    public class GenreOutgoingDTO
    {
        public string Genre { get; set; }
        public GenreOutgoingDTO(string genre)
        {
            this.Genre = genre;
        }
    }
}