using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;
using work_project.Roles.Common;

namespace work_project.Roles
{
    public class DEV : Employee, IProject
    {
        public string ProjectName { get; set; }
        public bool IsStudent { get; set; }

        public override void WritePersonInfo()
        {
            base.WritePersonInfo();
            if (IsStudent)
            {
                Console.Write($", ime projekta: {ProjectName}, is a student");
            }
            else
            {
                Console.Write($", ime projekta: {ProjectName}, isnt a student");
            }
        }
    }
}
