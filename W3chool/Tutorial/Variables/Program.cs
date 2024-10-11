using System.Globalization;

namespace Variables
{
    internal class Program
    {
        static void MyMethod(string fname = "Peter", int age = 19)
        {
            Console.WriteLine(fname + " is " + age);
        }

        static int Sum(int year)
        {
            return 2024 - year;
        }
        static void Main(string[] args)
        {
            MyMethod("Duc", 19);
            MyMethod("Nam", 22);
            MyMethod();

            Console.WriteLine("Your age is: " + Sum(2004));

            int a = Sum(2023);
            Console.WriteLine(a);

        }
    }
}

