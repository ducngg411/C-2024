using StudentManager.Entities;
using StudentManager.Services;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet tuSe = new Cabinet(); // Co 30 cho, tu co 30 slot trong count = 0

            Cabinet tuBiz = new Cabinet(); // 30 cho 
            tuBiz.AddStudent(new Student() { Id = "SS01", Name = "An" });
            tuBiz.AddStudent(new Student() { Id = "SS02", Name = "An" });
            tuBiz.AddStudent(new Student() { Id = "SS03", Name = "An" });

            tuSe.AddStudent(new Student() { Id = "SE01", Name = "An" });
            tuSe.AddStudent(new Student() { Id = "SE02", Name = "Binh" });
            tuSe.AddStudent(new Student() { Id = "SE03", Name = "Cuong" });

            tuSe.PrintStudentList();
            tuBiz.PrintStudentList();

        }

    }
}
