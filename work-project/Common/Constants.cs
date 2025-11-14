using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Factories;
using work_project.Roles;
using work_project.Services;

namespace work_project.Common
{
    public static class Constants
    {
        public static class Commands
        {
            public const string Add = "add";
            public const string Remove = "remove";
            public const string Display = "display";
            public const string List = "list";
            public const string RoleList = "<role_name>list";
            public const string Exit = "exit";

            public static readonly List<string> AllCmds = new List<string>() { Add, Remove, Display, List, RoleList, Exit };

            public static void ShowCommands()
            {
                Console.WriteLine("Available commands:");
                foreach (var command in AllCmds)
                {
                    Console.WriteLine(command);
                }
            }

            public static void SelectCommand(ServiceFactory serviceFactory, BaseService<Employee> baseService)
            {
                bool exit = false;  

                while (exit == false)
                {
                    string input = InputValidation.ReadNonEmptyString("Command: ").ToLower();

                    switch (input)
                    {
                        case "help":
                            Common.Constants.Commands.ShowCommands();
                            break;

                        case "add":
                            Common.Constants.Roles.ShowRoles();
                            serviceFactory.SelectService();
                            break;

                        case "remove":
                            baseService.Remove();
                            break;

                        case "display":
                            baseService.Display();
                            break;

                        case "list":
                            baseService.List();
                            break;

                        case "ceolist":
                            baseService.RoleList(Roles.Ceo);
                            break;

                        case "pmlist":
                            baseService.RoleList(Roles.Pm);
                            break;

                        case "devlist":
                            baseService.RoleList(Roles.Dev);
                            break;

                        case "dsnrlist":
                            baseService.RoleList(Roles.Dsnr);
                            break;

                        case "stlist":
                            baseService.RoleList(Roles.St);
                            break;

                        case "exit":
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Type help to see all available commands\n");
                            break;

                    }
                }
            }
        }
        public static class Roles
        {
            public const string Ceo = "ceo";
            public const string Pm = "pm";
            public const string Dev = "dev";
            public const string Dsnr = "dsnr";
            public const string St = "st";

            public const string PmFull = "project manager";
            public const string DevFull = "developer";
            public const string DsnrFull = "designer";
            public const string StFull = "software tester";

            public static void ShowRoles()
            {
                Console.WriteLine("Available roles:");
                Console.WriteLine($"{Ceo}\n{PmFull}/{Pm}\n{DevFull}/{Dev}\n{DsnrFull}/{Dsnr}\n{StFull}/{St}\n");
            }
        }
    }
}
