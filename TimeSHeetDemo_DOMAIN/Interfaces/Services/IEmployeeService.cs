using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSHeetDemo_Domain.Model;

namespace TimeSHeetDemo_Domain.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<Employee> GetEmployeeAsync(int id);
        Task<int> CreateEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);
    }
}
