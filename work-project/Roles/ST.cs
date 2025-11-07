using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;
using work_project.Roles.Common;

namespace work_project.Roles
{
    public class ST : Employee, IProject
    {
        public string ProjectName { get; set; }
        public bool UsesAutomatedTests { get; set; }

        public override void WritePersonInfo()
        {
            base.WritePersonInfo();
            if (UsesAutomatedTests)
            {
                Console.Write($", ime projekta: {ProjectName}, uses automated tests");
            }
            else
            {
                Console.Write($", ime projekta: {ProjectName}, doesnt use automated tests");
            }
        }
    }
}
