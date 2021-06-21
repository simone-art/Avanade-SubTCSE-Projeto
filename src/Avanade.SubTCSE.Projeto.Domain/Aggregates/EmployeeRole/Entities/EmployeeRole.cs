using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    //Record garante que as propiedades nao vai ser alteradas
    public record EmployeeRole
    {  
        
        //Constructor com parámetros
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            Rolename = roleName;
        }

        public EmployeeRole(string rolename)
        {
            Rolename = rolename;
        }

        //O Init só quem seta o valor é o constructor
        public string Id { get; init; }
        public string Rolename { get; init; }
    }
}
