using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            public static readonly List<string> AllCmds = new List<string>() { Add, Remove, Display, List, RoleList };

            public static void ShowCommands()
            {
                Console.WriteLine("Available commands:");
                foreach (var command in AllCmds)
                {
                    Console.WriteLine(command);
                }
            }
        }
        public static class Roles
        {
            public const string Ceo = "ceo";
            public const string Pm = "project manager/pm";
            public const string Dev = "developer/dev";
            public const string Dsnr = "designer/dsnr";
            public const string St = "software tester/st";

            public static readonly List<string> AllRoles = new List<string>() { Ceo, Pm, Dev, Dsnr, St };
            
            public static void ShowRoles()
            {
                Console.WriteLine("Available roles:");
                foreach (var role in AllRoles)
                {
                    Console.WriteLine(role);
                }
            }
        }
    }
}
