using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;
using work_project.Storage.Common;

namespace work_project.Storage
{
    public class Storage : IStorage
    {
        public List<Employee> Employees { get; } = new List<Employee>();
        
        public void Add(Employee employee)
        {
            Employees.Add(employee);
        }

        public void Delete(Guid id)
        {
            var emp = Employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                Employees.Remove(emp);
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            return Employees;
        }

        public IEnumerable<Employee> GetByRole(string role)
        {
            return Employees.Where(e =>
                e.Role.Equals(role, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Employee> GetNonCeo()
        {
            return Employees.Where(e =>
                !e.Role.Equals("CEO", StringComparison.OrdinalIgnoreCase));
        }

        public Employee GetByName(string firstName, string lastName)
        {
            return Employees.FirstOrDefault(e =>
                e.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                e.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
