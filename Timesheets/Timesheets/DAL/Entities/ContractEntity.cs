using System;

namespace Timesheets.DAL.Entities
{
    public class ContractEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate => DateTime.Now;
        public InvoiceEntity Invoice { get; set; }
    }
}
