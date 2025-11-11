using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;

namespace work_project.Services.Common
{
    public interface IBaseService<T> where T : Employee
    {
        void Add(string role);
        void Remove();
        void Display();
        void List();
        void RoleList(string role);
    }
}
