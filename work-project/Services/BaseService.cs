using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Common;
using work_project.Roles;


namespace work_project.Services
{
    public class BaseService<T> where T : Employee, new()
    {
        private readonly List <Employee> employees;

        public BaseService(List<Employee> employees)
        {
            this.employees = employees;
        }

        public virtual void Add()
        {
            Constants.Commands.ShowCommands();

            T emp = new T();

            emp.Role = InputValidation.ReadNonEmptyString("Role: ");
            emp.FirstName = InputValidation.ReadNonEmptyString("First name: ");
            emp.LastName = InputValidation.ReadNonEmptyString("Last name: ");
            emp.Age = InputValidation.ReadInt("Age: ");

            employees.Add(emp);
            Console.WriteLine($"{emp.FirstName} added successfully");
        }

        public virtual void Remove()
        {
            string firstName = InputValidation.ReadNonEmptyString("Enter first name to remove: ");
            string lastName = InputValidation.ReadNonEmptyString("Enter last name to remove: ");

            var employeeToDelete = employees.FirstOrDefault(e => e.FirstName.Equals(firstName));

            if (employeeToDelete != null)
            {
                employees.RemoveAll(e => e.Id == employeeToDelete.Id);
                Console.WriteLine($"{employeeToDelete.FirstName} {employeeToDelete.LastName} removed successfully");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }

        public virtual void Display()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Role}, {emp.FirstName} {emp.LastName}, star {emp.Age} godina");
            }
        }

    }
}
