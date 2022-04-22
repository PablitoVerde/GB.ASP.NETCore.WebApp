using System.Collections.Generic;

namespace Timesheets.DAL.Entities
{
    public class InvoiceEntity : BaseEntity
    {
        public string Name { get; set; }
        public bool IsPayed { get; set; }
        public decimal Sum { get; set; }
        public List<TaskEntity> Tasks { get; set; }

        public InvoiceEntity(string name)
        {
            Name = name;
        }
    }
}
