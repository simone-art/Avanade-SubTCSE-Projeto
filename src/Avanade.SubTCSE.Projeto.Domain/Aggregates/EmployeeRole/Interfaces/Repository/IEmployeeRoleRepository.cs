using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository
{
    interface IEmployeeRoleRepository
    {   
        //O que está dentro dos parêntesis é o objeto
        void addEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
