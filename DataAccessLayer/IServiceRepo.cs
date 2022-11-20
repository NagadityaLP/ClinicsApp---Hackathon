using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public interface IServiceRepo
    {
        Services CreateService(Services service);
        void DeleteService(string serviceId);
        Services UpdateService(Services service);
        Services GetService(string id);
        IQueryable<Services> GetAllServices();

    }
}
