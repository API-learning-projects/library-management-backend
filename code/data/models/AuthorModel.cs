using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Data.Models
{
    public class AuthorModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}