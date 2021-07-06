using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Base.Repository
{
    public interface IBaseRepository<TEntity, Tid>
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> FindById(Tid Id);
    }
}
