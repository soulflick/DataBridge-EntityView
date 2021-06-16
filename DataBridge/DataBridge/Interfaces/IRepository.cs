using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBridge.Interfaces
{

    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(Guid Id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<long> Insert(TEntity entity);
        Task<long> Insert(IEnumerable<TEntity> entity);
        Task<bool> Delete(TEntity entity);
        Task<int> Delete(Guid id);
        Task<bool> Update(TEntity entity);
        Task<bool> Update(IEnumerable<TEntity> entity);
        Task<IEnumerable<TEntity>> Query(Shared.Classes.MapperObject map);
    }

}
