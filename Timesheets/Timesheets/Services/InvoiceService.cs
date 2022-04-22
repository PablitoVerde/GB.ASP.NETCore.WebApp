using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.DAL.Entities;

namespace Timesheets.Services
{
    public class InvoiceService : IService<InvoiceDto>
    {
        public Task Create(InvoiceDto item)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<InvoiceDto> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<ContractEntity>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(InvoiceDto item)
        {
            throw new System.NotImplementedException();
        }
    }
}
