using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeRegister.Menu;

namespace EmployeeRegister
{
    internal class ProgramStart
    {
        private List<Employee> employeeList;
        public void Start(List<Employee>employeeListStore)
        {
            employeeList = employeeListStore;
            InputChoice inputChoice;
            do
            {
                PrintMenu();
                inputChoice = new InputChoice(Console.ReadLine());

                Console.WriteLine(inputChoice.Description);
                switch (inputChoice.Input)
                {
                    case InputEnum.AddEmployee:                       
                        AddEmployee();
                        break;
                    case InputEnum.ListEmployees:
                        ListEmployees();
                        break;
                }
            }
            while (inputChoice.Input != InputEnum.Exit);
            Console.WriteLine(Language.ExitingEnglish);
        }

        private void PrintMenu()
        {
            Console.WriteLine(Language.ChooseEnglish);            
            Console.WriteLine(InputChoice.GetDescriptionForInput(InputEnum.AddEmployee));
            Console.WriteLine(InputChoice.GetDescriptionForInput(InputEnum.ListEmployees));
            Console.WriteLine(InputChoice.GetDescriptionForInput(InputEnum.Exit));
        }

        public void AddEmployee()
        {
            string firstname = Util.AskForString(Language.EnterFirstNameEnglish, Language.FirstNameEnglish);
            string lastname = Util.AskForString(Language.EnterLastNameEnglish, Language.LastNameEnglish);
            int wage = Util.AskForInt(Language.EnterWageEnglish, Language.WageEnglish);
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
