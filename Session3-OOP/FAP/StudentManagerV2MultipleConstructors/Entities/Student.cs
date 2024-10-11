using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2MultipleConstructors.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString() => $"ID: {_id}, Name: {_name}, Yob: {_yob}, GPA: {_gpa}";

        public void ShowProfile() => Console.WriteLine(ToString());



        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public int GetYob()
        {
            return _yob;
        }

        public void SetYob(int value)
        {
            _yob = value;
        }

        public double SetGpa(double value) => _gpa = value;



        //1 form có nhiều cách điền, 1 account có những info phải điền trước, info khác điền sau, linh hoạt trong cách điền info. 

        //public Student(string id, string name, int yob, double gpa) 
        //{
        //    _id = id;
        //    _name = name;
        //    _yob = yob;
        //    _gpa = gpa;

        //}


    }
}
