using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSHeetDemo_Domain.Model;

namespace TimeSHeetDemo_Domain.Interfaces.Services
{
    public interface ITimeEntryService
    {
        Task<int> CreateEntryAsync(TimeEntry entry);
        Task<IEnumerable<TimeEntry>> GetEntriesForEmployee(int employeeId);
    }
}
