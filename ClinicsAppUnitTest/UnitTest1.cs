using BusinessLogic;
using DTOs;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicsAppUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]

        /*public void Valid_ClinicDtoObject_returns_valid_ClinicObject()
        {
            ServiceClinicMapperDto mapper = new ServiceClinicMapperDto { ClinicId = "cln133", ServiceId = 2, IsActive = true, AveragePrice = 137 };
            List<ServiceClinicMapperDto> list = new List<ServiceClinicMapperDto>(); 
            list.Append(mapper);

            ClinicDto clinicDto = new ClinicDto
            {
                ClinicID = "cln133",
                ClinicName = "cln",
                State = "TN",
                City = "Salem",
                Country = "Bharat",
                BusinessName = "Cln_business",
                CreatedDate = DateTime.Now,
                Latitude = "20.5937° N",
                Longitude = "78.9629° E",
                StreetAddress = "India",
                Zipcode = "35004-1819",
                ServiceClinicMappers = list
            };


            ServiceClinicMapper mapper1 = new ServiceClinicMapper { ClinicId = "cln133", ServiceId = 2, IsActive = true, AveragePrice = 137 };
            List<ServiceClinicMapper> list1 = new List<ServiceClinicMapper>();
            list1.Append(mapper1);

            Clinic clinicExpected = new Clinic
            {
                ClinicID = "cln133",
                ClinicName = "cln",
                State = "TN",
                City = "Salem",
                Country = "Bharat",
                BusinessName = "Cln_business",
                CreatedDate = DateTime.Now,
                Latitude = "20.5937° N",
                Longitude = "78.9629° E",
                StreetAddress = "India",
                Zipcode = "35004-1819",
                ServiceClinicMappers = list1
            };

            Clinic clinic_actual = logic.clinicDtoToClinic(clinicDto);

            Assert.AreEqual(clinicExpected, clinic_actual);
        }*/

        [TestMethod]
        [ExpectedException(typeof(LatitudeAndLongitudeNullException))]
        public void ClinicDto_With_NullValue_For_Latitude_ThrowsException()
        {

            ServiceClinicMapperDto mapper = new ServiceClinicMapperDto { ClinicId = "cln133", ServiceId = 2, IsActive = true, AveragePrice = 137 };
            List<ServiceClinicMapperDto> list = new List<ServiceClinicMapperDto>();
            list.Append(mapper);

            ClinicDto clinicDto = new ClinicDto
            {
                ClinicID = "cln133",
                ClinicName = "cln",
                State = "TN",
                City = "Salem",
                Country = "Bharat",
                BusinessName = "Cln_business",
                CreatedDate = DateTime.Now,
                Latitude = null,
                Longitude = "78.9629° E",
                StreetAddress = "India",
                Zipcode = "35004-1819",
                ServiceClinicMappers = list
            };

            Clinic clinic_actual = logic.clinicDtoToClinic(clinicDto);
        }

        [TestMethod]
        [ExpectedException(typeof(LatitudeAndLongitudeNullException))]
        public void ClinicDto_With_NullValue_For_Longitude_ThrowsException()
        {

            ServiceClinicMapperDto mapper = new ServiceClinicMapperDto { ClinicId = "cln133", ServiceId = 2, IsActive = true, AveragePrice = 137 };
            List<ServiceClinicMapperDto> list = new List<ServiceClinicMapperDto>();
            list.Append(mapper);

            ClinicDto clinicDto = new ClinicDto
            {
                ClinicID = "cln133",
                ClinicName = "cln",
                State = "TN",
                City = "Salem",
                Country = "Bharat",
                BusinessName = "Cln_business",
                CreatedDate = DateTime.Now,
                Latitude = "20.5937° N",
                Longitude = null,
                StreetAddress = "India",
                Zipcode = "35004-1819",
                ServiceClinicMappers = list
            };

            Clinic clinic_actual = logic.clinicDtoToClinic(clinicDto);
        }


        [TestMethod]
        [ExpectedException(typeof(ServiceNotFoundException))]
        public void ClinicDto_Without_ServiceObjects_ThrowsException()
        {

            ClinicDto clinicDto = new ClinicDto
            {
                ClinicID = "cln133",
                ClinicName = "cln",
                State = "TN",
                City = "Salem",
                Country = "Bharat",
                BusinessName = "Cln_business",
                CreatedDate = DateTime.Now,
                Latitude = "20.5937° N",
                Longitude = "78.9629° E",
                StreetAddress = "India",
                Zipcode = "35004-1819",
                ServiceClinicMappers = null
            };

            Clinic clinic_actual = logic.clinicDtoToClinic(clinicDto);
        }

        /*[TestMethod]
        [ExpectedException(typeof(ServicePriceGreaterThan250Exception))]
        public void ClinicDto_With_ServicePrice_GreaterThan_250_ThrowsException()
        {

            ServiceClinicMapperDto mapper = new ServiceClinicMapperDto { ClinicId = "CL202200002", ServiceId = 2, IsActive = true, AveragePrice = 290 };
            List<ServiceClinicMapperDto> list = new List<ServiceClinicMapperDto>();
            list.Append(mapper);

            ClinicDto clinicDto = new ClinicDto
            {
                ClinicID = "CL202200002",
                ClinicName = "cln1",
                State = "TN",
                City = "Salem",
                Country = "Bharat",
                BusinessName = "Cln_business",
                CreatedDate = DateTime.Now,
                Latitude = "20.5937° N",
                Longitude = "78.9629° E",
                StreetAddress = "India",
                Zipcode = "35004-1819",
                ServiceClinicMappers = list
            };

            Clinic clinic_actual = logic.clinicDtoToClinic(clinicDto);
        }*/



        


    }
}
