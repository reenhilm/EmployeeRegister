using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class ProgramStart
    {
        private List<Employee> employeeList;
        public void Start(List<Employee>employeeListStore)
        {
            employeeList = employeeListStore;
            string selectedAction;
            do
            {
                PrintMenu();
                selectedAction = Console.ReadLine();
                switch (selectedAction)
                {
                    case "1":
                        Console.WriteLine("Adding new employee ...");
                        AddEmployee();
                        break;
                    case "2":
                        Console.WriteLine("Listing employees ...");
                        ListEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            while (selectedAction != "9");
            Console.WriteLine("Exiting...");
        }

        private void PrintMenu()
        {
            Console.WriteLine("Choose the action you want to do: ");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. List employees");
            Console.WriteLine("9. Exit");
        }

        public void AddEmployee()
        {
            Console.WriteLine("Firstname:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Lastname:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Wage:");
            int wage = int.Parse(Console.ReadLine());
            employeeList.Add(new Employee(firstname, lastname, wage));
        }

        public void ListEmployees()
        {
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine(String.Format("{0} {1}, wage:{2}", emp.FirstName, emp.LastName, emp.Wage));
            }
        }
    }
}
