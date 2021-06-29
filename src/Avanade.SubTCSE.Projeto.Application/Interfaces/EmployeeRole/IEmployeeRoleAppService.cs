using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppService
    {
        //Task: tarefas que retornan instancias de objetos
        Task<EmployeeRoleDto> AddEmployeeRoleDto(EmployeeRoleDto employeeRoleDto);
    }
}
