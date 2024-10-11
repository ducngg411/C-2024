using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV9Property.Entites
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        // get() set() theo style hybird - property

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Yob
        {
            get => _yob; 
            set => _yob = value; 
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }

        }
    }
}
