using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV10PropertyHotkey.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //quen cu phap property, tao cac _field nhu binh thuong
        //go propfull tab tab

        //private string _id;

        public string Id
        {
            get => _id; 
            set => _id = value; 
        }

        public string Name 
        {   
            get => _name; 
            set => _name = value;  
        }

        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }

        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }

        // Dẹp luôn boiler plate get() set() ở trên nếu có thể 


    }
}
