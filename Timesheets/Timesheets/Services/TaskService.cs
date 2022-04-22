using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.DAL.Entities;

namespace Timesheets.Services
{
    public class TaskService : IService<TaskDto>
    {
        public Task Create(TaskDto item)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TaskDto> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<ContractEntity>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(TaskDto item)
        {
            throw new System.NotImplementedException();
        }
    }
}
