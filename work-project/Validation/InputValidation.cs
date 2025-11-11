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
                    Console.WriteLine("Input cannot be empty. Try again.");
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        public static int ReadInt(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                Console.Write("\n");
                if (int.TryParse(input, out result))
                    return result;
                Console.WriteLine("Invalid number. Try again.");
            }
        }

       public static  bool ReadBool(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim().ToLower();
                Console.Write("\n");

                if (input == "y" || input == "yes")
                    return true;
                else if (input == "n" || input == "no")
                    return false;

                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            }
        }
    }
}
