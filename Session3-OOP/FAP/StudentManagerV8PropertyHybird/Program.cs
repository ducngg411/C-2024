using StudentManagerV8PropertyHybird.Entites;

namespace StudentManagerV8PropertyHybird
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Id = "SE1"; // SET
            s1.Name = "Duc Nguyen";
            s1.Yob = 2004;
            s1.Gpa = 8.6;

            // tu nhien nhu nhin can cuoc cong dan 

            Console.WriteLine("S1 Details ... " + s1.ToString());
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s1);

            Student s2 = new Student()
            { 
                Id = "SE2", 
                Name = "Chinh Nguyen", 
                Gpa = 8.9, 
                Yob = 2006 
            };
            
            // Style viet chuan - new object kem Set() value cho property

            Console.WriteLine(s2);
            // Khong nham voi name argument

        }
    }
}
