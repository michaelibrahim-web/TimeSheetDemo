using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetDemo_Data.Entities;

namespace TimeSHeetDemo_Data.Entities
{
    public class TeamMember: BaseEntity
    {
   
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public int ClientId { get; set; }
        public int CategoryId { get; set; }

        public required string  FullName { get; set; }
        public required string Email { get; set; }
        public required string Role { get; set; }
        public required string Department { get; set; }
        public bool IsActive { get; set; }

        // Navigation
        public  Employee Employee { get; set; }
        public Project Project { get; set; }
        public Client Client { get; set; }
        public Category Category { get; set; }

    }

}
