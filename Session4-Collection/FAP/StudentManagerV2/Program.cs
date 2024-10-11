using StudentManagerV2.Entites;
using StudentManagerV2.Services;


namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCabinet tuSEStudent = new StudentCabinet(30);
            //ram: co 30 bien sv nam trong mang _arr

            tuSEStudent.AddAStudent(new Student() {Id = "SE1", Name= "An" });

            Student s = new Student() { Id = "SE2", Name = "Binh" };

            tuSEStudent.AddAStudent(s); // 2 chang 1 nang 

            tuSEStudent.PrintStudents();

            // Tu dung giao vien

            LecturerCabinet tuSELecturer = new LecturerCabinet(30);
            tuSELecturer.AddALecturer(new Lecturer() { Id = "00012345", Name = "Cuong", Salary = 20000000 });
            tuSELecturer.AddALecturer(new Lecturer() { Id = "00012346", Name = "Huong", Salary = 20_000_000 });

            tuSELecturer.PrintLecturers();
        }
    }
}
