using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetDemo_Data.Entities;

namespace TimeSHeetDemo_Data.Entities
{
    public class Category: BaseEntity
    {
        public required string CategoryName { get; set; }

        // Navigation
        public required ICollection<TimeEntry> TimeEntries { get; set; }
    }

}
