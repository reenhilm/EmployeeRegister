using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Wage { get; private set; }

        public Employee(string firstName, string lastName, int wage)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Wage = wage;
        }
    }
}