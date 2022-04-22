using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.DAL.Entities;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class TaskRepository : ITaskRepository
    {
        public Task Add(TaskEntity item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(TaskEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<TaskEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(TaskEntity item)
        {
            throw new NotImplementedException();
        }
    }
}