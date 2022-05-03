using System;
using System.Collections.Generic;

namespace Timesheets.Controllers.Models
{
    public class InvoiceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Sum { get; set; }
        public List<TaskDto> Tasks { get; set; }
    }
}