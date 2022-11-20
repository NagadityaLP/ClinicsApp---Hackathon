using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required, MaxLength(20)]
        public string PatientName { get; set; }
        List<Clinic> clinics { get; set; } = new List<Clinic>();

    }
}
