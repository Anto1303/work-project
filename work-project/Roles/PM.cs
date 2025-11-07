using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;
using work_project.Roles.Common;

namespace work_project.Roles
{
    public class PM : Employee, IProject
    {
        public string ProjectName { get; set; }

        public override void WritePersonInfo()
        {
            base.WritePersonInfo();
            Console.Write($", ime projekta: {ProjectName}");
        }
    }
}
