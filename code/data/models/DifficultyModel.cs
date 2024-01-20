using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Models
{
    public class DifficultyModel
    {
        [Key]
        public string Name { get; set; }
    }
}