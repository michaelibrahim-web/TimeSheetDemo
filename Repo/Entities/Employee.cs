using TimeSheetDemo_Data.Entities;

namespace TimeSHeetDemo_Data.Entities
{
    public class Employee: BaseEntity
    {
     
        public required string FullName { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Status { get; set; }
        public required string Role { get; set; }
        public int HoursPerWeek { get; set; }

        // Navigation
        public ICollection<TimeEntry>? TimeEntries { get; set; }
        public ICollection<TeamMember>? TeamMemberships { get; set; }
    }
}
