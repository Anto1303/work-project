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
using work_project.Services;
using work_project.Storage;
using static work_project.Common.Constants;

namespace work_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storage = new Storage.Storage();

            var serviceFactory = new Factories.ServiceFactory(storage);

            var baseService = new BaseService<Employee>(storage);

            bool exit = false;

            Common.Constants.Commands.ShowCommands();

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

                    case "remove": baseService.Remove();
                        break;

                    case "display": baseService.Display();
                        break;

                    case "list": baseService.List(); 
                        break;

                    case "ceolist":
                        baseService.RoleList(Common.Constants.Roles.Ceo);
                        break;

                    case "pmlist":
                        baseService.RoleList(Common.Constants.Roles.Pm);
                        break;

                    case "devlist":
                        baseService.RoleList(Common.Constants.Roles.Dev);
                        break;

                    case "dsnrlist":
                        baseService.RoleList(Common.Constants.Roles.Dsnr);
                        break;

                    case "stlist":
                        baseService.RoleList(Common.Constants.Roles.St);
                        break;

                    default:
                        Console.WriteLine("Type help to see all available commands\n");
                        break;

                }
            }

        }

    }
}
