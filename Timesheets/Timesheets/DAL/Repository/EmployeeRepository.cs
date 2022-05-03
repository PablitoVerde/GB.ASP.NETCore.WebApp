using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.DAL.Entities;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task Add(EmployeeEntity item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(EmployeeEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(EmployeeEntity item)
        {
            throw new NotImplementedException();
        }
    }
}