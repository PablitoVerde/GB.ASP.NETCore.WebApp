using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.DAL.Entities;

namespace Timesheets.Services
{
    public interface IService<T> where T : class
    {
        //CRUD
        Task Create(T item);
        Task Update(T item);
        Task Delete(int id);
        Task<T> Get(int id);
        Task<IList<ContractEntity>> GetAll();
    }
}
