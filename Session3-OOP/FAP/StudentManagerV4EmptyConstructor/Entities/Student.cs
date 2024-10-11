using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV4EmptyConstructor.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        // mac dinh neu class khong co constructor khu runtime, runtime sdk, hoac may ao se tu tao gium ta 1 constructor rong/default

        // ban co quyen chu dong tao constructor default neu ban thich - explicit constructor

        //public Student()
        //{

        //}

        // meo nho - ban co the go tu khoa ctor tab tu generate ra explicit constructor

        public Student()
        {
            
        }
    }
}
