using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Clinic
    {
        [Key]
        [MaxLength(15)]
        public string ClinicID { get; set; }
        [Required]
        [MaxLength(20)]
        public string ClinicName { get; set; }
        [Required]
        [MaxLength(25)]
        public string BusinessName { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        [MaxLength(20)]
        public string City { get; set; }
        [Required]
        [MaxLength(20)]
        public string State { get; set; }
        [Required]
        [MaxLength(20)]
        public string Country { get; set; }
        [Required, RegularExpression(@"^[0-9]{5}(?:-[0-9]{4})?$")]
        [MaxLength(12)]
        public string Zipcode { get; set; }
        [Required]
        [MaxLength(15)]
        public string Latitude { get; set; }
        [Required]
        [MaxLength(15)]
        public string Longitude { get; set; }
        [Required, MaxLength(50)]
        public string StreetAddress { get; set; }
        //public virtual List<Patient> Patients { get; set; }
        public virtual List<ServiceClinicMapper> ServiceClinicMappers { get; set; }
    }
    
}
