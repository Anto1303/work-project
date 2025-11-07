using System;

namespace work_project.Roles
{
    public class CEO : Employee
    {
        public int CeoYears { get; set; }

        public override void WritePersonInfo()
        {
            base.WritePersonInfo();
            Console.Write($", {CeoYears} godina kao CEO");
        }
    }
}
