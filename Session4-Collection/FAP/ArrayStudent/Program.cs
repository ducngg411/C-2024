using ArrayStudent.Entites;

namespace ArrayStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentArrayV5();
        }

        static void PlayWithStudentArrayV5()
        {
            Student s1 = new Student() { Id = "SE2", Name = "Binh" };

            Student[] arr = new Student[30];

            arr[0] = s1;

            arr[1] = new Student() { Id = "SE3", Name = "Cuong" };

            arr[2] = new Student() { Id = "SE4", Name = "Dung" };

            arr[3] = new Student() { Id = "SE5", Name = "Giang" };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is not null)
                {
                    arr[i].ShowProfile();
                }
            }

            Console.WriteLine("The Student List printed by using for each");

            foreach (Student x in arr)
            {
                if (x is not null)
                {
                    x.ShowProfile();
                }
            }
        }

        static void PlayWithStudentArray()
        {
            // tao mot ho so sv
            Student s1 = new Student();
            s1.Id = "SE1";
            s1.Name = "An"; // Dang Goi Ham Set(Value = set)

            Student s2 = new Student() { Id = "SE2", Name = "Binh" };

            Student s3, s4, s5, s6, s7, s8, s9, s10; // Khong choi ... nhen

            Student[] arr = { s1, s2 };

            //  ma mi         [0] 

            Student[] arr1 =
            {
                new Student() { Id = "SE3" },
                new Student() { Id = "SE4" }
            };

            arr1[0].ShowProfile();
            arr1[1].ShowProfile();


            //arr[0].Id = "SE3";
            //Console.WriteLine("2. Check s1 pointing to SE1 | AN | 8.6");
            //arr[0].ShowProfile();




        }

        static void PlayWithStudentArrayV3()
        {
            Student s1 = new Student() { Id = "SE2", Name = "Binh" };

            Student[] arr = new Student[30];

            arr[0] = s1;

            arr[1] = new Student() { Id = "SE3", Name = "Cuong" };

            arr[2] = new Student() { Id = "SE4", Name = "Dung" };

            arr[3] = new Student() { Id = "SE5", Name = "Giang" };

            arr[4] = arr[1]; // [4] [1] deu tro cuong
            arr[4].Id = "SE333";

            arr[0].ShowProfile();
            arr[1].ShowProfile();
            arr[2].ShowProfile();
            arr[3].ShowProfile();
        }

        static void PlayWithStudentArrayV4()
        {
            Student s1 = new Student() { Id = "SE2", Name = "Binh" };

            Student[] arr = new Student[30];

            arr[0] = s1;

            arr[1] = new Student() { Id = "SE3", Name = "Cuong" };

            arr[2] = new Student() { Id = "SE4", Name = "Dung" };

            arr[3] = new Student() { Id = "SE5", Name = "Giang" };

            arr[4] = arr[1]; // [4] [1] deu tro cuong
            arr[4].Id = "SE333";

            Console.WriteLine("The student list printed by using for loop");
            for (int i = 0; i < 4; i++)
            {
                arr[i].ShowProfile();
            }

            Console.WriteLine();

            foreach (Student x in arr)
            {
                x.ShowProfile(); // Chet luon sau khi in 4

                // x = arr[i] i = 0..29
                // foreach luon chay tu dau mang den cuoi mang 
            }
        }
    }
}


// Chot ha:
// Mang object la mang cua cac bien object, la mang con tro 
// 2 tang con tro 
// Tang 1: Ten mang - ma mi - con tro cai quan 1 dong bien khac, dong bien nay la bien con tro student, tung bien object , nhieu bien sat nhau [0] [1] [2]. Chungn dang cho tro vung new student() new object that su
// Ton 3 tang ram, 2 tang con tro, 1 tang new object co info that su 

// Tang 2: Tung bien student, tung bien object, nhieu bien sat nhau [0] [1] [2], chung dang tro vung new Student() new object that su
// 
// Mang primitive ton 2 tang Ram, 1 tang ma mi, 1 tang toan value that 
// Mang Primitibve ten ma mi cham xo ra length 


