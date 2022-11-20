using DTOs;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public interface IClinicRepo
    {
        Clinic Create(ClinicDto clinicDto);
        IQueryable<Clinic> GetAllClinics();
        void DeleteClinic(string id);
        Clinic GetClinic(string id);

        Clinic UpdateClinic(ClinicDto clinicDto);
    }
}
