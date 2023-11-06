using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Standart
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("OperationId")]
        public int OperationId { get; set; }
        public Operation Operation { get; set; }
        public int CodeProfession {  get; set; }
        public int DischargeBuilder { get; set; }
        [ForeignKey("TarifId")]
        public int TarifId { get; set; }
        public Tarif Tarif { get; set; }
        public TimeOnly TimeEnsure { get; set; }
        public TimeOnly ValuePerTime { get; set; }
    }
}
