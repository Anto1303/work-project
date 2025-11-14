using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using work_project.Common;
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

            Common.Constants.Commands.ShowCommands();

            Constants.Commands.SelectCommand(serviceFactory, baseService);
        }

    }
}
