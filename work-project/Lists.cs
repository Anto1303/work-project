using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_project.Roles;

namespace work_project
{
    public class Lists
    {
        public List<CEO> CEOs { get; set; } = new List<CEO>();
        public List<PM> PMs { get; set; } = new List<PM>();
        public List<DEV> DEVs { get; set; } = new List<DEV>();
        public List<DSNR> DSNRs { get; set; } = new List<DSNR>();
        public List<ST> STs { get; set; } = new List<ST>();
    }
}
