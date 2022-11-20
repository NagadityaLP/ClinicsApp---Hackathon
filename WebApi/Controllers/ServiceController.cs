using DataAccessLayer;
using Entities;
using System.Web.Http;
using System.Web.Http.OData;

namespace WebApi.Controllers
{
    public class ServiceController : ApiController
    {
        IServiceRepo repo = new ServiceRepo();
        public IHttpActionResult Post(Services service)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            repo.CreateService(service);
            return Created($"api/clinic/{service.ServiceID}", service);
        }

        [EnableQuery]
        public IHttpActionResult Get()
        {
            var services = repo.GetAllServices();
            if (services == null)
                return NotFound();
            return Ok(services);
        }

        public IHttpActionResult Delete(string id)
        {
            var service = repo.GetService(id);
            if (service == null)
                return NotFound();
            repo.DeleteService(id);
            return Ok(service);
        }

        public IHttpActionResult PutService(Services service)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            repo.UpdateService(service);
            return Ok(service);
        }
    }
}
