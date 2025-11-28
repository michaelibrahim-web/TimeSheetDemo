using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetDemo_Data.Entities;

namespace TimeSHeetDemo_Data.Entities
{
    public class Project: BaseEntity
    {
 
        public int ClientId { get; set; }
        public required string ProjectName { get; set; }
        public required string Description { get; set; }
        public int LeadId { get; set; }
        public required string Status { get; set; }
        public bool Archive { get; set; }

        // Navigation
        public required Client Client { get; set; }
        public ICollection<TeamMember>? TeamMembers { get; set; }
        public ICollection<TimeEntry>? TimeEntries { get; set; }
    }

}
