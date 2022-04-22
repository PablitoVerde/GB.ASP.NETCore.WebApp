using System.Collections.Generic;

namespace Timesheets.DAL.Entities
{
    public class EmployeeEntity
    {
        public string Name { get; set; }
        public IEnumerable<ContractEntity> TasksTaken { get; set; }
    }
}
