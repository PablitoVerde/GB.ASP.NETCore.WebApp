using System;

namespace Timesheets.DAL.Entities
{
    public class TaskEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsTaken { get; set; }
        public DateTime IsTakenTime { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime IsCompletedTime { get; set; }
    }
}
