using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSHeetDemo_Domain.Model
{
    public class TeamMember
    {
        public long Id { get; private set; }

        public int EmployeeId { get; private set; }
        public int ProjectId { get; private set; }

        public TeamMember(int employeeId, int projectId)
        {
            EmployeeId = employeeId;
            ProjectId = projectId;
        }
    }
}
