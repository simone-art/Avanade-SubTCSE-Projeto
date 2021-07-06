using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Base.Repository
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> Add(TEntity entity);
    }
}
