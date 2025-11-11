using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Common;
using work_project.Roles;
using work_project.Storage;


namespace work_project.Services
{
    public class BaseService<T> where T : Employee, new()
    {
        private readonly Storage.Storage storage;

        public BaseService(Storage.Storage storage)
        {
            this.storage = storage;
        }

        public virtual void Add(string role)
        {
            T emp = new T();

            emp.Role = role;
            emp.FirstName = InputValidation.ReadNonEmptyString("First name: ");
            emp.LastName = InputValidation.ReadNonEmptyString("Last name: ");
            emp.Age = InputValidation.ReadInt("Age: ");

            storage.Add(emp);
            Console.WriteLine($"{emp.FirstName} added successfully\n");
        }

        public void Remove()
        {
            string firstName = InputValidation.ReadNonEmptyString("Enter first name to remove: ");
            string lastName = InputValidation.ReadNonEmptyString("Enter last name to remove: ");

            var emp = storage.GetByName(firstName, lastName);

            if (emp != null)
            {
                storage.Delete(emp.Id);
                Console.WriteLine($"{emp.FirstName} {emp.LastName} removed successfully\n");
            }
            else
            {
                Console.WriteLine($"User not found\n");
            }
        }

        public void Display()
        {
            foreach (var emp in storage.GetAll())
            {
                emp.WritePersonInfo();
            }
        }

        public void List()
        {
            var nonCeoEmployees = storage.GetNonCeo();

            foreach (var emp in nonCeoEmployees)
            {
                emp.WritePersonInfo();
            }
        }

        public void RoleList (string role)
        {
            var empsInRole = storage.GetByRole(role);

            if (empsInRole.Any())
            {
                foreach(var emp in empsInRole)
                {
                    emp.WritePersonInfo();
                }
            }
            else
            {
                Console.WriteLine($"No {role} found");
            }

        }
    }
}
