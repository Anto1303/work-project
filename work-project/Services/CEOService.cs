using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Common;
using work_project.Roles;

namespace work_project.Services
{
    public class CEOService : BaseService<CEO>
    {
        private readonly Storage.Storage storage;

        public CEOService(Storage.Storage storage) : base (storage)
        {
            this.storage = storage;
        }

        public override void Add(string role)
        {
            if (storage.GetByRole("ceo").Any())
            {
                Console.WriteLine("A CEO already exists. Cannot add another.");
                return;
            }

            CEO emp = new CEO
            {
                Role = role,
                FirstName = InputValidation.ReadNonEmptyString("First name: "),
                LastName = InputValidation.ReadNonEmptyString("Last name: "),
                Age = InputValidation.ReadAge("Age: "),
                CeoYears = InputValidation.ReadInt("Years working as CEO: ")
            };

            storage.Add(emp);
            Console.WriteLine($"{emp.FirstName} added successfully\n");
        }
    }
}
