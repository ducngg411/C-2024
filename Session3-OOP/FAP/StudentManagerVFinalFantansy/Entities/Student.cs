using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerVFinalFantansy.Entities
{
    public class Student
    {
        // Quen cach go, propfull tab tab ra duoc ca _bascking field va get(), set() - boiler plate

        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        // Ki thuat nay trong C# goi la : auto-implemented property
        // hau truong runtime tu generate ra _backing fields va get() Set() truyen thong 


    }
}
