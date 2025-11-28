using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSHeetDemo_Domain.Model;

namespace TimeSHeetDemo_Domain.Interfaces.Services
{
    public interface IProjectService
    {
        Task<Project> GetProjectAsync(int id);
        Task<int> CreateProjectAsync(Project project);
    }
}
