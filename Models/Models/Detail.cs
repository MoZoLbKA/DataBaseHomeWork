using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Detail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TypeDetail { get; set; }
        [MaxLength(1000)]
        public string? Name { get; set; }
        [MaxLength(250)]
        public string? Measurement { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
