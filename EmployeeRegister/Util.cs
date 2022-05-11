using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal static class Util
    {
        public static string AskForString(string question, string questionName)
        {
            bool success = false;
            string line;
            do
            {
                Console.WriteLine(question);
                line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                    Console.WriteLine(string.Concat(Language.MustEnterValidEnglish + questionName));
                else
                    success = true;
            }
            while (!success);
            return line;
        }

        public static int AskForInt(string question, string questionName)
        {
            bool success = false;
            int iNumber = -1;
            do
            {
                Console.WriteLine(question);
                string line = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(line))
                { 
                    if(int.TryParse(line, out iNumber))
                        success = true;
                }
                if(!success)
                    Console.WriteLine(string.Concat(Language.MustEnterValidEnglish + questionName));

            }
            while (!success);
            return iNumber;
        }
    }
}
