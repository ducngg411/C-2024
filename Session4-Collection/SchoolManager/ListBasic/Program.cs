using ListBasic.Entites;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace ListBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithGenericV2();
        }

        static void PlayWithGenericV2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() {Id = "SE1",  Name = "An"});
            students.Add(new Student() {Id = "SE2",  Name = "Binh"});
            students.Add(new Student() {Id = "SE3",  Name = "Cuong"});

            Console.WriteLine("The list of student:");
            foreach (Student student in students) // for toi luon vung new() cua mang co gian 
            {
                student.ShowProfile();
            }
        }

        static void PlayWithListGeneric()
        {
            List<int> arr = new List<int>();

            // list trong c# chinh la arraylist<> ben java
            // arraylist trong c# khong giong arraylist<> ben java

            arr.Add(5);
            arr.Add(10);
            arr.Add(15);
            arr.Add(20);
            //arr.Add(3.14);
            //arr.Add("phuong trinh"); // no type safe a
            //arr.Add(new Student() { Id = "SE1", Name = "An" });

            int sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }

            Console.WriteLine("Sum:" + sum);

            Console.WriteLine("Printed with for loop");

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr.ElementAt(i)); // get(i) ben java 
            }

            Console.WriteLine("Printed with foreach loop");

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void PlayWithIntegerList()
        {
            ArrayList arr = new ArrayList(); // La class thung chua tua mang, nhung co gian va khong generic 

            arr.Add(5);
            arr.Add(10);
            arr.Add(15);
            arr.Add(20);
            arr.Add(3.14);
            arr.Add("phuong trinh"); // no type safe a
            arr.Add(new Student() { Id = "SE1", Name = "An" });

            // Mang dang co 4 phan tu, co san 4 value duoc gan vao 
            // 4 bien int ben trong, tuong lai con them bien int nua neu duoc add () them

            Console.WriteLine("The array list has values of:");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]); // [i] dung nhu mang khi get() 
            }

            Console.WriteLine("The array list is printed by using for each");

            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }

        }
    }
}
