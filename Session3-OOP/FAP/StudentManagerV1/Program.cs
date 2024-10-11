using StudentManagerV1.Entities;

namespace StudentManagerV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dxuc object clone cai pheu cai form, cai khuon, class, template, fill info vao - nhieu viec cung luc: goi new goi pheu constructor kem value vat lieu muc but do vao

            // giong dua he so cho phuong trinh bac 2 de co 1 pt cu the

            Student s1 = new Student("SE1", "Duc Nguyen", 2004, 9.0);
            Student s2 = new Student("SE1", "Dat Nguyen", 2004, 8.4);
            Console.WriteLine("S1 show profile");
            s1.ShowProfile();
            Console.WriteLine("S2 show profile");
            s2.ShowProfile();


            Console.WriteLine(s2.ToString());
            Console.WriteLine(s2);

            Student s3 = new("SE3", "Chinh Nguyen", 2004, 8.5);

            var s4 = new Student("SE4", "Minh Nguyen", 2004, 8.6);
            Console.WriteLine(s4);

            var s5 = new Student(name: "EM", yob: 2004, gpa: 9.0, id: "SE5");
            s5.ShowProfile();

            Student s6 = s5;

            Console.WriteLine("Check s5 before calling method");
            Console.WriteLine(s5); // Goi tham ten em ToString()
            PassAStudent(s5);
            Console.WriteLine(s5);

        }

        static void PassAStudent(Student x)
        {
            x.SetGpa(9.99);
        }
    }
}
