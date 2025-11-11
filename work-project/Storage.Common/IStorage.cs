using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;

namespace work_project.Storage.Common
{
    public interface IStorage
    {
        List<Employee> Employees { get; }
        void Add(Employee employee);
        void Delete(Guid id);
        IEnumerable<Employee> GetAll();
        IEnumerable<Employee> GetByRole(string role);
        IEnumerable<Employee> GetNonCeo();
        Employee GetByName(string firstName, string lastName);
    }
}
