using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSHeetDemo_Domain.Model
{
    public class Category
    {
        public int Id { get; private set; }
        public string CategoryName { get; private set; }

        public List<TimeEntry> TimeEntries { get; } = new();

        public Category(string title)
        {
            CategoryName = title;
        }
    }
}
