using System;

namespace Timesheets.DAL.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteTime { get; set; }

        public void Delete()
        {
            if (IsDeleted)
            {
                return;
            }
            else
            {
                IsDeleted = true;
                DeleteTime = DateTime.Now;
            }
        }

    }
}
