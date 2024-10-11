using StudentManagerV2.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Services
{
    public class LecturerCabinet
    {
        private Lecturer[] _arr;
        private int _count = 0;

        public LecturerCabinet(int size)
        {
            _arr = new Lecturer[size];
        }

        public void PrintLecturers()
        {
            if (_count <= 0)
            {
                Console.WriteLine("The cabinet is empty. Nothing to print");
                return;
            }

            Console.WriteLine($"There is/are {_count} Lecturer(S) in the cabinet");

            for (int i =0; i < _count; i++)
            {
                _arr[i].ShowProfile();
            }
        }

        public void AddALecturer(Lecturer x)
        {
            _arr[_count++] = x;
        }
    }
}
