using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;

namespace work_project.Services
{
    public class PMService : BaseService<PM>
    {
        private readonly Storage.Storage storage;

        public PMService(Storage.Storage storage) : base(storage)
        {
            this.storage = storage;
        }

        public override void Add(string role)
        {
            PM emp = new PM();

            emp.Role = role;
            emp.FirstName = InputValidation.ReadNonEmptyString("First name: ");
            emp.LastName = InputValidation.ReadNonEmptyString("Last name: ");
            emp.Age = InputValidation.ReadInt("Age: ");
            emp.ProjectName = InputValidation.ReadNonEmptyString("Project name: ");

            storage.Add(emp);
            Console.WriteLine($"{emp.FirstName} added successfully\n");
        }
    }
}
