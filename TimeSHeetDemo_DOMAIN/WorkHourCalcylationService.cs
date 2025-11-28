using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSHeetDemo_Domain.Model;

namespace TimeSHeetDemo_Domain
{
    public class WorkHourCalcylationService
    {
        public decimal CalculateOvertime(IEnumerable<TimeEntry> entries)
        {
            var totalHours = entries.Sum(x => x.Hours);
            return totalHours > 40 ? totalHours - 40 : 0;
        }
    }
}
