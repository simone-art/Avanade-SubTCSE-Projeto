using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository
{
    public interface IEmployeeRoleRepository
    {
        //O que está dentro dos parêntesis é o objeto
        //void addEmployeeRole(Entities.EmployeeRole employeeRole);
        //Task: tarefas que retornan instancias de objetos
        Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
