using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSHeetDemo_Domain.Model
{
    public class TimeEntry
    {
        public int Id { get; private set; }

        public int EmployeeId { get; private set; }
        public int ProjectId { get; private set; }
        public int ClientId { get; private set; }
        public int CategoryId { get; private set; }

        public DateTime EntryDate { get; private set; }
        public decimal Hours { get; private set; }

        public TimeEntry(
            int employeeId,
            int projectId,
            int clientId,
            int categoryId,
            DateTime entryDate,
            decimal hours)
        {
            if (hours <= 0)
                throw new ArgumentException("Hours must be greater than zero");

            EmployeeId = employeeId;
            ProjectId = projectId;
            ClientId = clientId;
            CategoryId = categoryId;
            EntryDate = entryDate;
            Hours = hours;
        }
    }
}
