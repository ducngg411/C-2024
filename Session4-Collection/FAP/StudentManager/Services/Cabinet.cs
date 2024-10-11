using StudentManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Services
{
    public class Cabinet
    {
        // dac tinh cua cai tu la: suc chua, chua loai ho so, do vat nao do, object nao do, ma la nhieu object. Lap trinh: chua nhieu la khai bao mang . mang nho di kem voi bien count de kiem soat phan tu mang 

        // Hanh dong cua cai tu : CRUD - CREATE | RETRIVE/READ | UPDATE | DELETE

        private Student[] _arr = new Student[30];
        private int _count = 0;

        public Cabinet(int size) // Tu dong theo yeu cau 
        {
            _arr = new Student[size];
        }

        public Cabinet() // hang sx hang loat 
        {
            
        }

        public void PrintStudentList()
        {
            Console.WriteLine($"These is/are {_count} student(s) in the cabinet");
            for (int i = 0; i < _count; i ++)
            {
                _arr[i].ShowProfile();
            }
        }

        public void AddStudent(Student s)
        {
            if (_count < 30)
            {
                _arr[_count++] = s;
            }
        }

        // overload la 1 the hien cua nguyen li da hinh 

         
    }
}
