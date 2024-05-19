using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarmLandAccountingUWP.Services
{
    public interface IRepository<T> where T : class
    {
        Task Create(T entity);

        Task Update (T entity);

        Task Delete();

        Task<List<T>> GetAll();
    }
}
