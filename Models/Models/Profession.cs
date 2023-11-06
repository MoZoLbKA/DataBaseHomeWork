using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Profession
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
    }
}
