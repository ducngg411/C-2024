using System.Security.Cryptography;

namespace Nullable
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob; // instance varibale neu ko co chu static di kem
        public double _gpa; // class level variable neu co chu static di kem
                            // ham goi la method la doan code duoc dat ten, xu li cac bien
                            // ham + field duoc goi chung la members of a class, thanh phan thanh vien cua class
        // contructor + method

        public Student(string id, string name, int yob, double gpa)
        {
            this._id = id;  
            this._name = name;  
            this._yob = yob;
            this._gpa = gpa;
        } 

        public void ShowProfile()
        {
            Console.WriteLine($"{_id} {_name} {_yob} {_gpa}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            PlayWithNullV6();
        }

        static void PlayWithNullV6()
        {
            int yob = 2004;
            string msg;
            if (yob > 2000)
            {
                msg = "GEN Z";
            }

            else
            {
                msg = "TOO OLD";
            }

            msg = yob > 2000 ? "GEN Z" : "TOO OLD";
            Console.WriteLine(msg);

            Student s1 = new Student("SE2", "An", 2004, 8.6);

            Student s2 = s1 == null ? new Student("SE1", "An", 2004, 8.6) : s1;
        }


        static void PlayWithNullV5()
        {
            Student s1 = null;
            Student s2 = s1 ?? new Student("SE1", "An", 2004, 8.6);
            s2.ShowProfile();

            s1 = new Student("SE9", "An", 2004, 8.6);
            Student s3 = s1 ?? new Student("SE3", "BA", 2003, 4.4);
            s3.ShowProfile();

            //???: duoc goi la toan tu ket hop, ket noi - coalesing operator 
        }

        static void PlayWithNullV3()
        {
            // Gan cac bien object cho nhau 
            int a = 10;
            int b = a; // vung ram b mang gia tri y trang a nhung 2 vung ram rieng biet
            b = 2004;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Student s3 = new Student("SE1", "AN", 2004, 8.6);
            Student s4 = s3; // hai bien object tro chung 1 vung ram 
            //s4.ShowProfile();
            s4._gpa = 999;
            //s3.ShowProfile();
            s3 = null;
            s3?.ShowProfile();
            s4.ShowProfile();
            

        }

        static void PlayWithNullV4()
        {
            Student s1 = null;
            Student s2 = s1;
            s2?.ShowProfile();

            s2 = s1 ?? new Student("SE2", "AN", 2004, 9.0);

            Console.WriteLine("s2 First");
            s2.ShowProfile();

            if (s1 != null)
            {
                s2 = s1;
            } 
            else
            {
                s2 = new Student("SE2", "AN", 2004, 9.0);
            }
            Console.WriteLine("s2 Second");
            s2.ShowProfile();
        }



        static void PlayWithNullV2()
        {
            Student s2 = null;
            //s2.ShowProfile();
            if (s2 == null)
            {
                Console.WriteLine("s2 points to null. Please creating an object before using it");
            }
            else
            {
                s2.ShowProfile();
            }

            if (s2 is null)
            {
                Console.WriteLine("s2 points to null. Please creating an object before using it");
            }
            else
            {
                s2.ShowProfile();
            }

            // ki thuat moi cua C# 
            Console.WriteLine("The new way to check null before using it");
            s2?.ShowProfile(); // dau ? + object name = null conditional operator : toan tu check null, gop kiem tra null truoc khi goi ham
        }


        static void PlayWithNullV1()
        {
            Student s1; // Khai bao bien khong gan gia tri -> vung ram tao ra nhung khong co gi = gia tri rac

            Student s2 = null; // khai bao bien, gan gia tri = null -> vung ram tao ra co gia tri -> tra ve toa do cua ram -> null co toa do la 0 0 0 tuc la khong co gi de hien 

        }

        static void CreateAStudnetObject()
        {
            Student s3 = new Student("SE1", "AN", 2004, 8.6); // khai bao bien + khai bao object (new + constructor) -> 2 vung ram duoc tao ra, 1 vung ram cua khai bao bien, 1 vung ram cua object chua attributies va method, vung ram nay sau cung tra ra dia chi cua ram do. dia chi nay se duoc luu trong vung khai bao bien.  
            s3.ShowProfile();
        }

    }
}
