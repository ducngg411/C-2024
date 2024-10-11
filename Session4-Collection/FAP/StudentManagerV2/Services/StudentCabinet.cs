using StudentManagerV2.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Services
{
    public class StudentCabinet
    {
        private Student[] _arr;
        private int _count = 0; // Tu ban dau chua co mon do, mang chua co value cho cac bien, cho cac phan tu, o day chinh la [i] = new Student() se la 1 value cho phan tu/bien thu [i] cua mang 

        // tu do dong theo yeu cau gia chu, so ngan tuy chon

        public StudentCabinet(int size)
        {
            _arr = new Student[size];
        }

        // cac ham crud cho tung mon do trong tu, tung bien thu [i]
        // Xu li info, xu ly cac object tu entity student

        public void PrintStudents()
        {
            // ko in den het mang, coi chung null reference exception, chi for den count, for thi phai check null
            // 

            if (_count <= 0)
            {
                Console.WriteLine("The cabinet is empty. Nothing there");
                return;
            }

            Console.WriteLine($"There is/are {_count} Student(S) in the cabinet");

            for (int i = 0; i < _count; i++)
            {
                //Console.WriteLine(_arr[i]);
                    _arr[i].ShowProfile();
            }

            
        }

        public void AddAStudent(Student x)
        {
            _arr[_count++] = x;
        }
    }
}
