namespace NullableV2
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double? _gpa; // diem tb co the bo trong tu tu dien vao 

        public Student(string id, string name, int yob, double? gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public void showProfile()
        {
            Console.WriteLine($"Id: {_id} | Name: {_name} | Year of birth: {_yob} | GPA: {_gpa}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("SE1", null, 2004, null);
            s1.showProfile();

            Student s2 = new Student("SE2", "Duc Nguyen", 2004, 8.6);
            s2.showProfile();

            Student s3 = new Student("SE3", "Cuong Nguyen", 2004, null);
            s3.showProfile(); 

            Student s4 = null;
            Console.WriteLine("Check null");
            s4?.showProfile(); 

            Student? s5 = null;
            Console.WriteLine("Check null 2");
            s5?.showProfile();
        }
    }
}
