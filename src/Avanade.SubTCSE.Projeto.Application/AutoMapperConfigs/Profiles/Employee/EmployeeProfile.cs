using AutoMapper;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.Employee
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Dtos.Employee.EmployeeDto, Domain.Aggregates.Employee.Entities.Employee>()
                //Res é de referencia... acho
                //Usando constructor pra fazer mapeamento
                .ConstructUsing((ctor, res) =>
                {
                    return new Domain.Aggregates.Employee.Entities.Employee(

                        firstName: ctor.PrimeiroNome,
                        secondName: ctor.SobreNome,
                        birthday: ctor.Aniversario,
                        active: ctor.Ativo,
                        salary: ctor.Salario,
                        employeeRole: res.Mapper.Map<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>(ctor.Cargo));


                })
                //Forallmembers: pra nao mapear ou ignorar o que está fora do constructor
                .ForAllMembers(i => i.Ignore());

            //Mapeamento origem-destino
            CreateMap<Domain.Aggregates.Employee.Entities.Employee, Dtos.Employee.EmployeeDto>()
                .ForMember(dest => dest.Identificador, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PrimeiroNome, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.SobreNome, opt => opt.MapFrom(src => src.SecondName))
                .ForMember(dest => dest.Aniversario, opt => opt.MapFrom(src => src.Birthday))
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Active))
                .ForMember(dest => dest.Salario, opt => opt.MapFrom(src => src.Salary))
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.EmployeeRole))
                .ForAllMembers(i => i.Ignore());

        }
    }
}
