using Entities;
using System.Linq;

namespace DataAccessLayer
{
    public class ServiceRepo : IServiceRepo
    {
        private ClinicDBContext db = new ClinicDBContext();
        public Services CreateService(Services service)
        {
            db.Services.Add(service);
            db.SaveChanges();

            return service;
        }

        public Services UpdateService(Services service)
        {
            db.Entry(service).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return service;
        }

        public IQueryable<Services> GetAllServices()
        {
            return db.Services.ToList().AsQueryable();
        }

        public void DeleteService(string serviceId)
        {
            db.Services.Remove(db.Services.Find(serviceId));
            db.SaveChanges();
        }

        public Services GetService(string id)
        {
            return db.Services.Find(id);
        }
    }
}
