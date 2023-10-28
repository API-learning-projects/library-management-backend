namespace LibraryManagement.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }

        public BookDTO(int id)
        {
            this.Id = id;
        }
    }
}