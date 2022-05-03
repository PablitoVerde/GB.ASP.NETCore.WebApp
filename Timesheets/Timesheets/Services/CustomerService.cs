using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.DAL.Entities;

namespace Timesheets.Services
{
    public class CustomerService : IService<CustomerDto>
    {
        public Task Create(CustomerDto item)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<CustomerDto> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<ContractEntity>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(CustomerDto item)
        {
            throw new System.NotImplementedException();
        }
    }
}
