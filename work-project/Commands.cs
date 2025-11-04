using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;

namespace work_project
{
    public static class Commands
    {
        public static Lists lists = new Lists();

        public static void Add(String role)
        {

            switch (role)
            {
                case "ceo":

                    CEO ceo = new CEO();

                    ceo.FirstName = Validation.ReadNonEmptyString("First name: ");

                    ceo.LastName = Validation.ReadNonEmptyString("Last name: ");

                    ceo.Age = Validation.ReadInt("Age: ");

                    ceo.CeoYears = Validation.ReadInt("Years being CEO: ");

                    lists.CEOs.Add(ceo);


                    break;

                case "projectmanager":
                case "pm":
                    PM pm = new PM();

                    pm.FirstName = Validation.ReadNonEmptyString("First name: ");

                    pm.LastName = Validation.ReadNonEmptyString("Last name: ");

                    pm.Age = Validation.ReadInt("Age: ");

                    pm.Project = Validation.ReadNonEmptyString("Project name: ");

                    lists.PMs.Add(pm);

                    break;

                case "developer":
                case "dev":
                    DEV dev = new DEV();

                    dev.FirstName = Validation.ReadNonEmptyString("First name: ");

                    dev.LastName = Validation.ReadNonEmptyString("Last name: ");

                    dev.Age = Validation.ReadInt("Age: ");

                    dev.Project = Validation.ReadNonEmptyString("Project name: ");

                    string s = Validation.ReadNonEmptyString("Is student? yes/no");
                    
                    if (s == "yes")
                    {
                        dev.IsStudent = true;
                    }
                    else if (s == "no")
                    {
                        dev.IsStudent = false;
                    }

                    lists.DEVs.Add(dev);
                    break;

                case "designer":
                case "dsnr":
                    DSNR dsnr = new DSNR();

                    dsnr.FirstName = Validation.ReadNonEmptyString("First name: ");

                    dsnr.LastName = Validation.ReadNonEmptyString("Last name: ");

                    dsnr.Age = Validation.ReadInt("Age: ");

                    dsnr.Project = Validation.ReadNonEmptyString("Project name: ");

                    s = Validation.ReadNonEmptyString("Can draw? yes/no");

                    if (s == "yes")
                    {
                        dsnr.CanDraw = true;
                    }
                    else if (s == "no")
                    {
                        dsnr.CanDraw = false;
                    }

                    lists.DSNRs.Add(dsnr);

                    break;

                case "softwaretester":
                case "st":
                    ST st = new ST();

                    st.FirstName = Validation.ReadNonEmptyString("First name: ");

                    st.LastName = Validation.ReadNonEmptyString("Last name: ");

                    st.Age = Validation.ReadInt("Age: ");

                    st.Project = Validation.ReadNonEmptyString("Project name: ");

                    s = Validation.ReadNonEmptyString("Uses automated tests? yes/no");
                    
                    if (s == "yes")
                    {
                        st.UsesAutomatedTests = true;
                    }
                    else if (s == "no")
                    {
                        st.UsesAutomatedTests = false;
                    }

                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        public static void Remove(string role)
        {
            switch (role)
            {
                case "ceo":
                    string Name = Validation.ReadNonEmptyString("Enter first name to remove: ");
                    var CeoToRemove = lists.CEOs.FirstOrDefault(c => c.FirstName.ToLower() == Name);
                    if(CeoToRemove != null)
                    {
                        lists.CEOs.Remove(CeoToRemove);
                        Console.WriteLine($"Ceo {Name} removed.");
                    }
                    else
                    {
                        Console.WriteLine("Ceo not found.");
                    }
                    
                    break;

                case "projectmanager":
                case "pm":
                    Name = Validation.ReadNonEmptyString("Enter first name to remove: ");
                    var PmToRemove = lists.PMs.FirstOrDefault(c => c.FirstName.ToLower() == Name);
                    if (PmToRemove != null)
                    {
                        lists.PMs.Remove(PmToRemove);
                        Console.WriteLine($"Project Manager {Name} removed.");
                    }
                    else
                    {
                        Console.WriteLine("Project Manager not found.");
                    }

                    break;

                case "developer":
                case "dev":
                    Name = Validation.ReadNonEmptyString("Enter first name to remove: ");
                    var DevToRemove = lists.PMs.FirstOrDefault(c => c.FirstName.ToLower() == Name);
                    if (DevToRemove != null)
                    {
                        lists.PMs.Remove(DevToRemove);
                        Console.WriteLine($"Developer {Name} removed.");
                    }
                    else
                    {
                        Console.WriteLine("Developer not found.");
                    }
                    break;

                case "designer":
                case "dsnr":
                    Name = Validation.ReadNonEmptyString("Enter first name to remove: ");
                    var DsnrToRemove = lists.PMs.FirstOrDefault(c => c.FirstName.ToLower() == Name);
                    if (DsnrToRemove != null)
                    {
                        lists.PMs.Remove(DsnrToRemove);
                        Console.WriteLine($"Designer {Name} removed.");
                    }
                    else
                    {
                        Console.WriteLine("Designer not found.");
                    }
                    break;

                case "softwaretester":
                case "st":
                    Name = Validation.ReadNonEmptyString("Enter first name to remove: ");
                    var StToRemove = lists.PMs.FirstOrDefault(c => c.FirstName.ToLower() == Name);
                    if (StToRemove != null)
                    {
                        lists.PMs.Remove(StToRemove);
                        Console.WriteLine($"Software Tester {Name} removed.");
                    }
                    else
                    {
                        Console.WriteLine("Software Tester not found.");
                    }
                    break;
            }
        }

        public static void Display(bool showCEO)
        {
            if (showCEO)
            {
                if (lists.CEOs.Count == 1)
                {
                    CEO ceo = lists.CEOs[0];
                    Console.WriteLine($"CEO, {ceo.FirstName} {ceo.LastName}, star {ceo.Age} godina.");
                }
                else
                {
                    Console.WriteLine("No CEO has been added yet.");
                }
            }

            foreach (var pm in lists.PMs)
            {
                Console.WriteLine($"Project Manager, {pm.FirstName} {pm.LastName}, star {pm.Age} godina.");
            }

            foreach (var dev in lists.DEVs)
            {
                Console.WriteLine($"Developer, {dev.FirstName} {dev.LastName}, star {dev.Age} godina.");
            }

            foreach (var dsnr in lists.DSNRs)
            {
                Console.WriteLine($"Designer, {dsnr.FirstName} {dsnr.LastName}, star {dsnr.Age} godina.");
            }

            foreach (var st in lists.STs)
            {
                Console.WriteLine($"Software Tester, {st.FirstName} {st.LastName}, star {st.Age} godina.");
            }

        }

        public static void DisplayRole(string role)
        {
            switch (role)
            {
                case "ceo":
                    if (lists.CEOs.Count == 1)
                    {
                        CEO ceo = lists.CEOs[0];
                        Console.WriteLine($"CEO, {ceo.FirstName} {ceo.LastName}, star {ceo.Age} godina.");
                    }
                    else
                    {
                        Console.WriteLine("No CEO has been added yet.");
                    }
                    break;
                case "pm":
                    foreach (var pm in lists.PMs)
                    {
                        Console.WriteLine($"Project Manager, {pm.FirstName} {pm.LastName}, star {pm.Age} godina.");
                    }
                    break;
                case "dev":
                    foreach (var dev in lists.DEVs)
                    {
                        Console.WriteLine($"Developer, {dev.FirstName} {dev.LastName}, star {dev.Age} godina.");
                    }
                    break;
                case "dsnr":
                    foreach (var dsnr in lists.DSNRs)
                    {
                        Console.WriteLine($"Designer, {dsnr.FirstName} {dsnr.LastName}, star {dsnr.Age} godina.");
                    }
                    break;
                case "st":
                    foreach (var st in lists.STs)
                    {
                        Console.WriteLine($"Software Tester, {st.FirstName} {st.LastName}, star {st.Age} godina.");
                    }
                    break;
            }
        }

    }
}
