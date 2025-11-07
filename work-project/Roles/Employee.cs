using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_project.Roles
{
    public abstract class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual void WritePersonInfo()
        {
            Console.WriteLine($"{Role}, {FirstName} {LastName}, star {Age} godina");
        }
    }
}
