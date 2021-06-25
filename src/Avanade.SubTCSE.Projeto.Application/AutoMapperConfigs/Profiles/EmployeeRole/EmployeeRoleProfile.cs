﻿using AutoMapper;
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

            CreateMap<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, Dtos.EmployeeRole.EmployeeRoleDto>()
                .ForMember(dest => dest.Identificador, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.Rolename))
                .ForAllOtherMembers(i => i.Ignore());


        }
    }
}