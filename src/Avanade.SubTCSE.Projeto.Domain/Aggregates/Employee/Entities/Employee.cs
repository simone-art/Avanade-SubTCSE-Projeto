using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntity<string>
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public DateTime Birthday { get; set; }

        public bool Active { get; set; }

        public decimal Salary { get; set; }

        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; set; }


    }
}
