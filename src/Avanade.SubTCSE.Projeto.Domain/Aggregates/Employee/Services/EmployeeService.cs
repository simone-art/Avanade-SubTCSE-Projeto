using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Services
{
    public class EmployeeService : IEmployeeService

    {
        public Task<Entities.Employee> AddEmployee(Entities.Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
