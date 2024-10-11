using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV1.Entities
{
    public class Student
    {
        private string _id; // dac diem, field, state, bien nam ngoai ham nhung trong class cua 1 object theo quy tac: con lac da va _ tu dau tien
        private string _name;
        private int _yob;
        private double _gpa;

        // Lay cay but dien info vao form khi minh new, clone, xin 1 cai form de luu info, khi minh can luu info cua 1 sv moi bat ki
        // noi theo cai khuon duc, thi no la cai pheu hung vat lieu do vao trong khuon

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;

            //this._id = id; // thua nhung khong sai 
            //this._name = name;
            //this._yob = yob;
            //this._gpa = gpa;
            // LAP TRINH CLASS/OOP Chinh la lap trinh xu li tren cac bien 1 cach chung nhat, lat hoi do info se co gia tri cu the   
        }

        public string GetName()
        {
            return _name;
        }

        public int GetYob()
        {
            return _yob;
        }

        public double GetGgpa()
        {
            return _gpa;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetYob(int yob)
        {
            _yob = yob;
        }

        public void SetGpa(double gpa)
        {
            _gpa = gpa;
        }

        // Ham Flex thong tin nhieu info hon, thay vi le tung mieng info get le
        // Moi ca nhan co 1 cai profile tren mxh: fb, tiktok, linked in

        public void ShowProfile()
        {
            Console.WriteLine("My Profile:");
            Console.WriteLine("ID: " + _id);
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Yob: " + _yob);
            Console.WriteLine("GPA: " + _gpa);
        }

        //public override string ToString()
        //{
        //    return $"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";
        //}

        public override string ToString() => $"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";

    }

}

// Class la 1 ten goi chung, 1 danh tu chung, la ten goi cho su phan nhom, phan loai/classify 1 dam object co diem tuong dong ve dac diem va hanh vi

// An Binh Cuong Dung .... share chung dac diem hanh vi

// dac diem : id , name , yob, place of birth, address, major, gpa,..

// hanh vi : DoQuiz(), DoFinalExam(), ...


// 1 object o tren duoc nhin theo 2 khia canh

// 1 dac diem (tinh - state) : id, name, yob, gpa - Field

// 2 hanh vi (dong -behaviour) : DoPresentation(), ComputeBill()  -  method, function, ham

// 2 thong tin tren duoc goi chung la members of an object, member of a class

// Thiet ke oop

// 1. Nhan dien ra cac object
// 2. Chia nhom object, tim nhom object - tim class, theo dac diem chung, theo hanh dong chung
// Nhom student, nhom lecturer 
// 3. Tao dung ra dan khung cho class, cai form voi cac cho trong de dien vao sau nay 
// 4. Chuan bi viec nhan info vao, dien info vao form de co duoc object 
// Ngoai doi chinh la xin form, lay but dien vo
// Trong code, dien form chinh la fill vao cac field trong class
// Hanh dong trong code chinh la ham. Ham nay goi la constructor()  giong nhu cay but bat dau dien form
// 5. Object xong, dien but vao o trong xong


