using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Services;
using work_project.Storage;

namespace work_project.Factories
{
    public class ServiceFactory
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
                    case "ceo":
                        ceoService.Add(role);
                        IsRunning = false;
                        break;

                    case "pm":
                    case "project manager":
                        pmService.Add(role);
                        IsRunning = false;
                        break;

                    case "dev":
                    case "developer":
                        devService.Add(role);
                        IsRunning = false;
                        break;

                    case "dsnr":
                    case "designer":
                        dsnrService.Add(role);
                        IsRunning = false;
                        break;

                    case "st":
                    case "software tester":
                        stService.Add(role);
                        IsRunning = false;
                        break;

                    default:
                        Console.WriteLine("Role doesnt exist or incorrect wording\n");
                        Common.Constants.Roles.ShowRoles();
                        break;
                }
            }
        }
    }
}
