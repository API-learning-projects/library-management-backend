namespace LibraryManagement.DTO
{
    public class BookOutgoingDTO
    {
        public string Title { get; set; }

        public BookOutgoingDTO(string title)
        {
            this.Title = title;
        }
    }
}