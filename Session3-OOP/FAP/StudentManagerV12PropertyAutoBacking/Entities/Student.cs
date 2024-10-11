using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV12PropertyAutoBacking.Entities
{
    public class Student
    {
        public int Id { get; set; } // luc runtime se sinh ra gium _id
        public string Name { get; set; } // Tu sinh ra gium backing field
        public int Yob { get; set; }
        public double Gpa { get; set; }



    }
}
