using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Models
{
    public class GenreModel
    {
        [Key]
        public string Name { get; set; }

        public GenreModel()
        {
        }
    }
}