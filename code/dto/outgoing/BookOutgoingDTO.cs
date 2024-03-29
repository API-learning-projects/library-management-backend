namespace LibraryManagement.DTO
{
    public class BookOutgoingDTO
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Difficulty { get; set; }
        public int Duration { get; set; }
        public int? BuyPrice { get; set; }
        public int? BorrowPrice { get; set; }

        public BookOutgoingDTO(string title, string genre, string author, string difficulty, int duration, int? buyPrice, int? borrowPrice)
        {
            this.Title = title;
            this.Genre = genre;
            this.Author = author;
            this.Difficulty = difficulty;
            this.Duration = duration;
            this.BuyPrice = buyPrice;
            this.BorrowPrice = borrowPrice;
        }
    }
}