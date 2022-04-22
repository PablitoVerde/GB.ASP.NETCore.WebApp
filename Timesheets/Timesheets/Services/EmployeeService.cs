using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.DAL.Entities;

namespace Timesheets.Services
{
    public class EmployeeService : IService<EmployeeDto>
    {
        public Task Create(EmployeeDto item)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<EmployeeDto> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<ContractEntity>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(EmployeeDto item)
        {
            throw new System.NotImplementedException();
        }
    }
}
