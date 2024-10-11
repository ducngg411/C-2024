using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3EmptyConstructor.Entites
{
    public class Student
    {
        private string _id; 
        private string _name;
        private int _yob;
        private double _gpa;

        //public void SetName(string name)
        //{
        //    _name = name;
        //}

        //public void SetYob(int yob)
        //{
        //    _yob = yob;
        //}

        public void SetName(string value)
        {
            _name = value;
        }

        public void SetYob(int value)
        {
            _yob = value;
        }


        public override string? ToString()
        {
            return $"ID: {_id} | Name: {_name} | Yob: {_yob} | GPA: {_gpa}";
        }

        public void ShowProfile()
        {
            Console.WriteLine(ToString());
        }
    }
}
