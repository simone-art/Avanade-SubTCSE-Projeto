using Avanade.SubTCSE.Projeto.Infra.Data.Repositories.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Infra.Data.Repositories.EmployeeRole
{
    public class EmployeeRoleRepository
        : BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>
        , IEmployeeRoleRepository
    {
        public Task<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole> AddEmployeeRole(Domain.Aggregates.EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            throw new System.NotImplementedException();
        }
    }
}
