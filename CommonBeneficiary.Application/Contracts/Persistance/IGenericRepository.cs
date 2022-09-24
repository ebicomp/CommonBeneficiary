using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Contracts.Persistance
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAll();
        Task<bool> Exist(long id);
        Task<T> Get(long id);
        Task<T> Add(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
