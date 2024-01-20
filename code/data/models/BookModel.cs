using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Data.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int? BuyPrice { get; set; }
        public int? BorrowPrice { get; set; }

        public GenreModel Genre { get; set; }

        public AuthorModel Author { get; set; }
        public DifficultyModel Difficulty { get; set; }
    }
}