using AutoMapper;
using DTOs;
using Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class AutoMapper
    {
        public Clinic MapperConfig(ClinicDto clinicDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ServiceClinicMapperDto, ServiceClinicMapper>();
                cfg.CreateMap<ClinicDto, Clinic>();
            });
            //Using automapper
            var mapper = new Mapper(config);
            var clinic = mapper.Map<Clinic>(clinicDto);
            var serviceClinicMapper = mapper.Map<List<ServiceClinicMapper>>(clinicDto.ServiceClinicMappers);
            clinic.ServiceClinicMappers = serviceClinicMapper;

            return clinic;
        }
    }
}
