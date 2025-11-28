using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSHeetDemo_Domain.Model
{
    public class Employee
    {
        public long Id { get; private set; } 
        public string FullName { get; private set; }
        public string Position { get; private set; }

       
        public List<TimeEntry> TimeEntries { get; } = new();

        public Employee(string fullName, string position)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Employee name is required");

            FullName = fullName;
            Position = position;
        }

        public void ChangeName(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                throw new ArgumentException("New name cannot be empty");

            FullName = newName;
        }
    }
    }
