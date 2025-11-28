using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetDemo_Data.Entities;

namespace TimeSHeetDemo_Data.Entities
{
    public class Client: BaseEntity
    {

        public required string ClientName { get; set; }
        public required string Email { get; set; }
        public required string Address { get; set; }
        public required string ZipCode { get; set; }
        public required string Country { get; set; }

       
        public  ICollection<Project>? Projects { get; set; }
        public ICollection<TimeEntry>? TimeEntries { get; set; }
    }

}
