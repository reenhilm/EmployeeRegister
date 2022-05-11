using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister.Menu
{
    internal class InputChoice
    {
        public InputChoice(string selectedinput)
        {
            if (int.TryParse(selectedinput, out int iSelectedInput))
            {
                switch (iSelectedInput)
                {
                    case (int)InputEnum.AddEmployee:
                        Input = InputEnum.AddEmployee;
                        break;
                    case (int)InputEnum.ListEmployees:
                        Input = InputEnum.ListEmployees;
                        break;
                    case (int)InputEnum.Exit:
                        Input = InputEnum.Exit;
                        break;
                    default:
                        Input = InputEnum.Invalid;
                        break;
                }
            }
            else
                Input = InputEnum.Invalid;
        }


        public InputEnum Input { get; private set; }
        public string Description {
            get
            {
                return GetDescriptionForInput(Input);
            }
        }

        public static string GetDescriptionForInput(InputEnum input)
        {
            switch (input)
            {
                case InputEnum.AddEmployee:
                    return AddEmployeeDescription;
                case InputEnum.ListEmployees:
                    return ListEmployeesDescription;
                case InputEnum.Exit:
                    return ExitDescription;
                case InputEnum.Invalid:
                    return InvalidDescription;

                default:
                    return InvalidDescription;
            }
        }

        private static string AddEmployeeDescription = string.Concat((int)InputEnum.AddEmployee, Language.AddEmployeeEnglish);
        private static string ListEmployeesDescription = string.Concat((int)InputEnum.ListEmployees, Language.ListEmployeesEnglish);
        private static string ExitDescription = string.Concat((int)InputEnum.Exit, Language.ExitEnglish);
        private static string InvalidDescription = Language.InvalidEnglish;
    }
}
