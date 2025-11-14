using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_project
{
    public class InputValidation
    {
        public static string ReadNonEmptyString(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                Console.Write("\n");
                if (string.IsNullOrWhiteSpace(input))
                    Console.WriteLine("Input cannot be empty. Try again.\n");
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                Console.Write("\n");
                if (int.TryParse(input, out int result)) //TryParse je slican kao i parse ali tryparse ako uspije daje true a ako ne uspije napraviti konverziju vraca false.
                    return result;                   //Parse kad ne uspije napraviti konverziju daje error i ne vraca bool.
                Console.WriteLine("Invalid number. Try again.\n");
            }
        }

       public static bool ReadBool(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim().ToLower();  //? - ako se unese null, nece pucati nego ce vratiti null, nece pucati program.
                Console.Write("\n");                                  //.Trim() ukljanja sve razmake na pocetku i kraju stringa, ne između.

                if (input == "y" || input == "yes")
                    return true;
                else if (input == "n" || input == "no")
                    return false;

                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.\n");
            }
        }

        public static int ReadAge(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                Console.Write("\n");
                if (int.TryParse(input, out int result))
                {
                    int age = result;
                    if(age > 18 && age < 65)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("User has to be in between the ages of 18 and 65\n");
                    }
                }
                else
                {
                    Console.WriteLine("Input is not a number\n");
                }
            }
        }
    }
}
