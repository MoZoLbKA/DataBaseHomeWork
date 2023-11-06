using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Tarif
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CountPerHour { get; set; }
        [ForeignKey("StandartId")]
        public int StandartId { get; set; }
        public Standart Standart { get; set; }
    }
}
