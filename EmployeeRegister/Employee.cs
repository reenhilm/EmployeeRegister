using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class Employee
    {
        public string FirstName;
        public string LastName;
        public int Wage;

        public Employee(string FirstName, string LastName, int wage)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Wage = wage;
        }
    }
}