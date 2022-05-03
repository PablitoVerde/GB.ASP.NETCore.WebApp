using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.DAL.Entities;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class ContractRepository : IContractRepository
    {
        public Task Add(ContractEntity item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(ContractEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<ContractEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContractEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(ContractEntity item)
        {
            throw new NotImplementedException();
        }
    }
}