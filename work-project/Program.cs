using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;

namespace work_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("Type \"help\" to display available commands");
                Console.Write("Command: ");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "help":
                        Console.WriteLine("\nAvailable commands:");
                        Console.WriteLine("  add     - Add a new role(CEO, ProjectManager or PM, Developer or DEV, Designer or DSNR and SoftwareTester or ST)");
                        Console.WriteLine("  remove  - Remove an existing role");
                        Console.WriteLine("  display - Display all roles");
                        Console.WriteLine("  list    - List available commands");
                        Console.WriteLine(" (ceo/pm/dev/dsnr/st)list - Display all employees in a role");
                        break;

                    case "add":
                        string Role = Validation.ReadNonEmptyString("Enter role: ");
                        Commands.Add(Role);
                        break;

                    case "remove":
                        Role = Validation.ReadNonEmptyString("Enter role to remove: ");
                        Commands.Remove(Role);
                        break;
                        
                    case "display":
                        bool showCeo = true;
                        Commands.Display(showCeo);
                        break;

                    case "list":
                        showCeo = false;
                        Commands.Display(showCeo);
                        break;

                    case "ceolist":
                        string listrole = "ceo";
                        Commands.DisplayRole(listrole);
                        break;

                    case "pmlist":
                        listrole = "pm";
                        Commands.DisplayRole(listrole);
                        break;

                    case "devlist":
                        listrole = "dev";
                        Commands.DisplayRole(listrole);
                        break;

                    case "dsnrlist":
                        listrole = "dsnr";
                        Commands.DisplayRole(listrole);
                        break;

                    case "stlist":
                        listrole = "stlist";
                        Commands.DisplayRole(listrole);
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }

            }

        }

    }
}
