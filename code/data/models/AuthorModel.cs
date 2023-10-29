using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Models
{
    public class AuthorModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public AuthorModel()
        {
        }
    }
}