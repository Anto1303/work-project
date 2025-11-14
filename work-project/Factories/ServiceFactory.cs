using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Factories.Common;
using work_project.Services;
using work_project.Common;
using work_project.Storage;

namespace work_project.Factories
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly Storage.Storage storage;

        public ServiceFactory(Storage.Storage storage)
        {
            this.storage = storage;
        }

        public void SelectService()
        {
            var ceoService = new CEOService(storage);
            var pmService = new PMService(storage);
            var devService = new DEVService(storage);
            var dsnrService = new DsnrService(storage);
            var stService = new STService(storage);

            bool IsRunning = true;
            
            while (IsRunning)
            {
                string role = InputValidation.ReadNonEmptyString("Enter role: ").ToLower();

                switch (role)
                {
                    case Constants.Roles.Ceo:
                        ceoService.Add(role);
                        IsRunning = false;
                        break;

                    case Constants.Roles.Pm:
                    case Constants.Roles.PmFull:
                        pmService.Add(role);
                        IsRunning = false;
                        break;

                    case Constants.Roles.Dev:
                    case Constants.Roles.DevFull:
                        devService.Add(role);
                        IsRunning = false;
                        break;

                    case Constants.Roles.Dsnr:
                    case Constants.Roles.DsnrFull:
                        dsnrService.Add(role);
                        IsRunning = false;
                        break;

                    case Constants.Roles.St:
                    case Constants.Roles.StFull:
                        stService.Add(role);
                        IsRunning = false;
                        break;

                    default:
                        Console.WriteLine("Role doesnt exist or incorrect wording\n");
                        work_project.Common.Constants.Roles.ShowRoles();
                        break;
                }
            }
        }
    }
}
