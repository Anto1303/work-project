using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;
using work_project.Roles.Common;

namespace work_project.Roles
{
    public class DSNR : Employee, IProject
    {
        public string ProjectName { get; set; }
        public bool CanDraw { get; set; }

        public override void WritePersonInfo()
        {
            base.WritePersonInfo();
            if (CanDraw)
            {
                Console.Write($", ime projekta: {ProjectName}, can draw");
            }
            else
            {
                Console.Write($", ime projekta: {ProjectName}, cant draw");
            }
        }
    }
}
