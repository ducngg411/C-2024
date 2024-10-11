using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV6Property.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        // bo qua constructor, goi default() sau do goi get(), set()

        public string GetId()
        {
            return _id;
        }

        public void SetId(string value)
        {
            _id = value;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        //
    }
}
