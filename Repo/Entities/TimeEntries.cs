using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetDemo_Data.Entities;

namespace TimeSHeetDemo_Data.Entities
{
    public class TimeEntry: BaseEntity
    {
         
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public int ClientId { get; set; }
        public int CategoryId { get; set; }

        public required string Description { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal Hours { get; set; }
        public decimal Overtime { get; set; }

        // Navigation
        public  Employee employee { get; set; }
        public  Project Project { get; set; }
        public  Client Client { get; set; }
        public  Category Category { get; set; }
    }

}
