using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.DAL.Entities;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task Add(CustomerEntity item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CustomerEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(CustomerEntity item)
        {
            throw new NotImplementedException();
        }
    }
}