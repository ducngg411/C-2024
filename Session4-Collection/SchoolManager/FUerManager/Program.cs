using FUerManager.Entites;
using FUerManager.Services;

namespace FUerManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentCabinet();
            PlayWithLecturerCabinet();
        }

        static void PlayWithCabinet()
        {
            Cabinet<int> tuInt = new Cabinet<int>();
            tuInt.AddItem(5);
            tuInt.AddItem(10);
            tuInt.AddItem(15);
            tuInt.AddItem(20);

            tuInt.PrintItems();
        }

        static void PlayWithStudentCabinet()
        {
            Cabinet<Student> student = new Cabinet<Student>();
            student.AddItem(new Student() { Id = "SE1" });
            student.AddItem(new Student() { Id = "SE2", Name = "Duc" });
            student.AddItem(new Student() { Id = "SE3", Name = "Binh", Gpa = 8.6 });
            student.AddItem(new Student() { Id = "SE4", Name = "Minh", Gpa = 8.6, Yob = 2004 });

            student.PrintItems();   
        }

        static void PlayWithLecturerCabinet()
        {
            Cabinet<Lecturer> lecturer = new Cabinet<Lecturer>();
            lecturer.AddItem(new Lecturer() { Id = "0000102310" });
            lecturer.AddItem(new Lecturer() { Id = "0000102311", Name = "Duc" });
            lecturer.AddItem(new Lecturer() { Id = "0000102312", Name = "Binh", Salary = 86_000_000 });
            lecturer.AddItem(new Lecturer() { Id = "0000102313", Name = "Minh", Salary = 86_000_000, Yob = 2004 });

            lecturer.PrintItems();
        }
    }
}
