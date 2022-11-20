using DataAccessLayer;
using DTOs;
using Entities;
using System;
using System.Web.Http;
using System.Web.Http.OData;

namespace WebApi.Controllers
{
    public class ClinicController : ApiController
    {
        IClinicRepo repo = new ClinicRepo();
        public IHttpActionResult Post(ClinicDto clinicDto)
        {
            if(!ModelState.IsValid)
                return BadRequest("Invalid Input");
            Clinic clinic;
            try
            {
                clinic = repo.Create(clinicDto);
                if (clinic == null)
                    throw new Exception("Service not available or service price greater than 250");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            return Created($"api/clinic/{clinic.ClinicID}", clinic);
        }

        [EnableQuery]
        public IHttpActionResult Get()
        {
            var clinics = repo.GetAllClinics();
            if (clinics == null) 
                return NotFound();
            return Ok(clinics); 
        }

        public IHttpActionResult Delete(string id)
        {
            var clinic = repo.GetClinic(id);
            if (clinic == null)
                return NotFound();
            repo.DeleteClinic(id);
            return Ok(clinic);
        }

        public IHttpActionResult PutClinic(ClinicDto clinicDto)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            Clinic clinic;
            try
            {
                clinic = repo.UpdateClinic(clinicDto);
                /*if (clinic == null)
                    throw new Exception("Cannot update because Service not available or service price greater than 250");*/
                return Ok(clinic);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
