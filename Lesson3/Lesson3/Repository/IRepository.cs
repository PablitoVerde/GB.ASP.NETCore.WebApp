using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson3.Repository
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();
        T GetById(int id);
        Task Create(T item);
        Task Update(T item);
        Task Delete(int id);
    }

}
