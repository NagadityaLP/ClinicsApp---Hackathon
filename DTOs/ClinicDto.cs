using System.Collections.Generic;
using System;
using Entities;

namespace DTOs
{
    public class ClinicDto
    {
        public string ClinicID { get; set; }
        public string ClinicName { get; set; }
        public string BusinessName { get; set; }
        public DateTime CreatedDate { get; set; }
        
        //public virtual List<Patient> Patients { get; set; }
        public virtual List<ServiceClinicMapperDto> ServiceClinicMappers { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string StreetAddress { get; set; }
    }
}

