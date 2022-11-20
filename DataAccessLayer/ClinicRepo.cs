using DTOs;
using Entities;
using BusinessLogic;
using System.Linq;

namespace DataAccessLayer
{
    public class ClinicRepo : IClinicRepo
    {
        private ClinicDBContext db = new ClinicDBContext();
        public Clinic Create(ClinicDto clinicDto)
        {
            Clinic clinic = logic.clinicDtoToClinic(clinicDto);
            if (clinic == null)
                return null;
            foreach (var each_clinic in db.Clinics.ToList())
            {
                if (each_clinic.ClinicName.Equals(clinic.ClinicName))
                    throw new ClinicNameNotUniqueException("Clinic name already exist. Try a different one");
            }
            db.Clinics.Add(clinic);
            db.SaveChanges();

            return clinic;
        }

        public Clinic UpdateClinic(ClinicDto clinicDto)
        {
            Clinic clinic = logic.clinicDtoToClinic(clinicDto);
            if (clinic == null)
                return null;
            db.Entry(clinic).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return clinic;
        }

        public IQueryable<Clinic> GetAllClinics()
        {
            return db.Clinics.ToList().AsQueryable();
        }

        public void DeleteClinic(string id)
        {
           db.Clinics.Remove(db.Clinics.Find(id));
            db.SaveChanges();
        }

        public Clinic GetClinic(string id)
        {
            return db.Clinics.Find(id);
        }
    }
}
