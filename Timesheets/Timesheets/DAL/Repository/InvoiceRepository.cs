using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.DAL.Entities;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public Task Add(InvoiceEntity item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(InvoiceEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<InvoiceEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InvoiceEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(InvoiceEntity item)
        {
            throw new NotImplementedException();
        }
    }
}