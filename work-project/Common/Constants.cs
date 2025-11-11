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
            public const string Pm = "pm";
            public const string Dev = "dev";
            public const string Dsnr = "dsnr";
            public const string St = "st";

            private const string Pm2 = "project manager/pm";
            private const string Dev2 = "developer/dev";
            private const string Dsnr2 = "designer/dsnr";
            private const string St2 = "software tester/st";

            private static readonly List<string> AllRoles = new List<string>() { Ceo, Pm2, Dev2, Dsnr2, St2 };
            
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
