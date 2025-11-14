using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;

namespace work_project.Services
{
    public class DEVService : BaseService<DEV>
    {
        private readonly Storage.Storage storage;

        public DEVService(Storage.Storage storage) : base(storage)
        {
            this.storage = storage;
        }

        public override void Add(string role)
        {
            DEV emp = new DEV
            {
                Role = role,
                FirstName = InputValidation.ReadNonEmptyString("First name: "),
                LastName = InputValidation.ReadNonEmptyString("Last name: "),
                Age = InputValidation.ReadAge("Age: "),
                ProjectName = InputValidation.ReadNonEmptyString("Project name: "),
                IsStudent = InputValidation.ReadBool("Is student? yes/no: ")
            };

            storage.Add(emp);
            Console.WriteLine($"{emp.FirstName} added successfully\n");
        }
    }
}
