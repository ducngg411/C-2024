using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bmi = BmiCaculator.GetBmi(70, 1.7); // auto indentify data type of variables
            Console.WriteLine("Your bmi is:" + bmi); // concatenation
            Console.WriteLine("Your bmi is: {0}", bmi); // placeholder
            Console.WriteLine($"Your bmi is: {bmi}"); // interpolation
            Console.WriteLine($@"Your bmi is: {bmi}");

            var bmiMessage = $"BMI: {bmi}";
             
            Console.WriteLine(bmiMessage);

        }
    }
}
