using Avanade.SubTCSE.Projeto.Application.Dtos.Base;

namespace Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole
{
   public  class EmployeeRoleDto : BaseDto
    {
        //public string Identificador { get; set; }
        //Ao usar a herencia da class BaseDto o código pode ser refactorado
        //Por isso está comentado o public string Identificador
        public string Cargo{ get; set; }
    }
}
