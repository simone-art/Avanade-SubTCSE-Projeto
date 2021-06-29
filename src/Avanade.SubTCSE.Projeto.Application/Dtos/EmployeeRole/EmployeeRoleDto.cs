using Avanade.SubTCSE.Projeto.Application.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole
{
   public  class EmployeeRoleDto : BaseDto
    {
        //public string Identificador { get; set; }
        //Ao usar a herencia da class BaseDto o código pode ser refactorado
        public string Cargo{ get; set; }
    }
}
