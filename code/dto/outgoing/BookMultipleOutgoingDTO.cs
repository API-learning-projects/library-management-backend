namespace LibraryManagement.DTO
{
    public class BookMultipleOutgoingDTO
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Difficulty { get; set; }
        public int Duration { get; set; }

        public BookMultipleOutgoingDTO(string title, string genre, string author, string difficulty, int duration)
        {
            this.Title = title;
            this.Genre = genre;
            this.Author = author;
            this.Difficulty = difficulty;
            this.Duration = duration;
        }
    }
}