using StudentManagerV2.Entites;
using StudentManagerV3Generic.Services;

namespace StudentManagerV3Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentAndLectuererCabinet();
        }


        static void PlayWithStudentAndLectuererCabinet()
        {
            Cabinet<Student> tuSEStudent = new(10);
            tuSEStudent.AddAnItem(new Student() { Id = "SE1", Name = "An" });
            tuSEStudent.AddAnItem(new Student() { Id = "SE2", Name = "Minh" });

            Cabinet<Lecturer> tuSELecturer = new(10);
            tuSELecturer.AddAnItem(new Lecturer() { Id = "00012130", Name = "Tung", Salary = 20_000_000, Yob = 1994 });
            tuSELecturer.AddAnItem(new Lecturer() { Id = "00012132", Name = "Chinh", Salary = 20_000_000, Yob = 1997 });

            tuSELecturer.PrintAnItems();
            tuSEStudent.PrintAnItems();

            Cabinet<double> tuDouble = new(10);
            tuDouble.PrintAnItems();
        }

        static void PlayWithIntCabinet()
        {
            Cabinet<int> tuInt = new Cabinet<int>(10);
            tuInt.AddAnItem(123);
            tuInt.AddAnItem(456);
            tuInt.AddAnItem(789);
            tuInt.AddAnItem(8910);

            tuInt.PrintAnItems();

        }
    }
}

// Tham so hoa cai value cau ham -> DA Quen Tu C, Java khi choi ham Void F(int x)

// Tham so hoa cai data type dua vao ham, data type cung la tham so luon Void F(??? X)