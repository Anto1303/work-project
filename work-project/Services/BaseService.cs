using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Common;
using work_project.Roles;
using work_project.Services.Common;
using work_project.Storage;


namespace work_project.Services
{
    public class BaseService<T> : IBaseService<T> where T : Employee, new()
    {
        private readonly Storage.Storage storage;

        public BaseService(Storage.Storage storage)
        {
            this.storage = storage;
        }

        public virtual void Add(string role)
        {
            T emp = new T
            {
                Role = role,
                FirstName = InputValidation.ReadNonEmptyString("First name: "),
                LastName = InputValidation.ReadNonEmptyString("Last name: "),
                Age = InputValidation.ReadAge("Age: ")
            };

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
            var emps = storage.GetAll();
            if(emps.Count()  > 0)
            {
                foreach (var emp in emps)
                {
                    emp.WritePersonInfo();
                }

                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("No Employees have been added yet");
            }
            Console.Write("\n");
        }

        public void List()
        {
            var nonCeoEmployees = storage.GetNonCeo();

            if(nonCeoEmployees.Count() > 0)
            {
                foreach (var emp in nonCeoEmployees)
                {
                    emp.WritePersonInfo();
                }

                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("No Employees have been added yet");
            }
            Console.Write("\n");
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
                Console.WriteLine($"No {role} found\n");
            }

        }
    }
}
