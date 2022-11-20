using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Services
    {
        [Key]
        public int ServiceID { get; set; }
        [Required]
        [MaxLength(20)]
        public string ServiceName { get; set; }
        [Required]
        public int ServiceCode { get; set; }
        [Required, MaxLength(50)]
        public string ServiceDescription { get; set; }
        //public virtual List<ServiceClinicMapper> ServiceClinicMappers { get; set; }

    }
}
