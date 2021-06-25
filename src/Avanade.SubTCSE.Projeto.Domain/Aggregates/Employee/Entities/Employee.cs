﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntity<string>
    {
        public Employee(string firstName, 
            string secondName, 
            DateTime birthday, 
            bool active, 
            decimal salary, 
            EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            FirstName = firstName;
            SecondName = secondName;
            Birthday = birthday;
            Active = active;
            Salary = salary;
            EmployeeRole = employeeRole;
        }

        public string FirstName { get; init; }

        public string SecondName { get; init; }

        public DateTime Birthday { get; init; }

        public bool Active { get; init; }

        public decimal Salary { get; init; }

        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; init; }


    }
}
