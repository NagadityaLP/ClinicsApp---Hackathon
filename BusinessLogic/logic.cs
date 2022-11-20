using DTOs;
using AutoMapper;
using Entities;
using System.Collections.Generic;
using System.Security.Policy;
using System;

namespace BusinessLogic
{
    public class logic
    {
        //Latitude and Longitude should not be null
        //Service cost should not be more than 250 dollars
        //clinicName should be unique
        //cost can be different for same service in different clinics
        //clinic and services should be active
        //clinic can be added only if service is available
        //if a clinic is inactivated all services would be inactivated
        //if a new service is added, notification has to be sent to the patients

        public static Clinic clinicDtoToClinic(ClinicDto clinicDto)
        {

            if (clinicDto.Latitude == null || clinicDto.Longitude == null)
                throw new LatitudeAndLongitudeNullException("Latitude and Longitude cannot be null");
            if (clinicDto.ServiceClinicMappers == null)
                throw new ServiceNotFoundException("Clinic must and should provide atleast one service");
            foreach (var item in clinicDto.ServiceClinicMappers)
            {
                if (item.AveragePrice > 250)
                    throw new ServicePriceGreaterThan250Exception("Service's price cannot exceed Rs.250");
            }

            AutoMapper autoMapper = new AutoMapper();
            Clinic clinic = autoMapper.MapperConfig(clinicDto);

            
            return clinic;

            /*
             * Manual Mapping
             * 
             * Clinic clinic = new Clinic();
            clinic.ClinicID = clinicDto.ClinicID;
            clinic.ClinicName = clinicDto.ClinicName;
            clinic.StreetAddress = clinicDto.StreetAddress;
            clinic.City = clinicDto.City;
            clinic.Country = clinicDto.Country;
            clinic.State = clinicDto.State;
            if (clinicDto.Latitude == null || clinicDto.Longitude == null)
                throw new LatitudeAndLongitudeNullException("Latitude and Longitude cannot be null");
            clinic.Latitude = clinicDto.Latitude;
            clinic.Longitude = clinicDto.Longitude;
            clinic.Zipcode = clinicDto.Zipcode;
            clinic.BusinessName = clinicDto.BusinessName;
            clinic.CreatedDate = clinicDto.CreatedDate;

            if (clinicDto.ServiceClinicMappers == null)
                throw new ServiceNotFoundException("Clinic must and should provide atleast one service");

            List<ServiceClinicMapper> csl = new List<ServiceClinicMapper>();
            foreach (var item in clinicDto.ServiceClinicMappers)
            {
                ServiceClinicMapper cs = new ServiceClinicMapper();
                cs.IsActive = item.IsActive;
                cs.ServiceId = item.ServiceId;
                cs.ClinicId = clinicDto.ClinicID;
                if (item.AveragePrice > 250)
                    throw new ServicePriceGreaterThan250Exception("Service's price cannot exceed Rs.250");
                cs.AveragePrice = item.AveragePrice;

                csl.Add(cs);
            }

            clinic.ServiceClinicMappers = csl;*/


        }

    }
}
