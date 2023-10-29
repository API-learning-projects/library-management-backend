using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        
        public BookModel(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}