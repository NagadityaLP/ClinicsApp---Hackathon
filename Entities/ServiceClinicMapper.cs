using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ServiceClinicMapper
    {
        [Key, Column(Order = 0)]
        [MaxLength(15)]
        public string ClinicId { get; set; }
        [Key, Column(Order = 1)]
        public int ServiceId { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int AveragePrice { get; set; }

    }
}
