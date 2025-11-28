using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSHeetDemo_Domain.Model
{
    public class Project
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int ClientId { get; private set; }

        public List<TimeEntry> TimeEntries { get; } = new();

        public Project(string name, int clientId)
        {
            Name = name;
            ClientId = clientId;
        }
    }
}
