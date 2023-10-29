namespace LibraryManagement.DTO
{
    public class BookDTO
    {
        public string Title { get; set; }

        public BookDTO(string title)
        {
            this.Title = title;
        }
    }
}