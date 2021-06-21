using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {

        public EmployeeRoleProfile()
        {
            //Fazendo mapeamento origem-destino
            //Dtos.EmployeeRole.EmployeeRoleDto {origem}
            //Domain.Aggregates.EmployeeRole.Entities.EmployeeRol {destino}
            CreateMap<Dtos.EmployeeRole.EmployeeRoleDto, Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
            .ForCtorParam("rolename", opt => opt.MapFrom(src => src.Cargo));
        }
    }
}
