using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSHeetDemo_Domain.Model
{
    public class Client
    {
        public int Id { get; private set; }
        public string CompanyName { get; private set; }

        public List<Project> Projects { get; } = new();

        public Client(string companyName)
        {
            CompanyName = companyName;
        }
    }
}
