using StudentManagerV7Encapsulation.Entities;

namespace StudentManagerV7Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithGetSet();
            PlayWithGetSetWithoutEncapsulation();
        }

        // Khao sat ve get - lay thong tin cua 1 bien
        // Set - thay doi thong tin cua 1 bien
        static void PlayWithGetSetWithoutEncapsulation()
        {
            Student s1 = new Student();

            //get()
            Console.WriteLine("GET: Id = " + s1.Id);
            Console.WriteLine("GET: Yob = " + s1.Yob);

            //Set()
            s1.Yob = 2004;
            Console.WriteLine("GET: Id = " + s1.Id);
            Console.WriteLine("GET: Yob = " + s1.Yob);
        }


        static void PlayWithGetSet()
        {
            int yob = 2000; // bien local, bien khai bao trong ham, dung cu phap con Lac Da, khong co shift _ nhu field

            Console.WriteLine("Get YOB: " + yob);

            int age = 2024 - yob;
            Console.WriteLine("Get age: " + age);

            // Set - thay doi dieu gi do 

            yob = 2004;
            Console.WriteLine("Get yob (Again):" + yob);


            
        }
    }
}
