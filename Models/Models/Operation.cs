using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Operation
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = null!;


    }
}
