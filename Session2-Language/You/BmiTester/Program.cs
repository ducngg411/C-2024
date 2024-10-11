using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bmi = BmiCaculator.GetBmi(70, 1.7); //var: trả về kiểu dữ liệu, biến mang data type là value được gán vào // bmi chính là double, di value đưa cho nó là double
            // type inferent - suy luận ngầm kiểu data type của 1 variable
            Console.WriteLine($"Bmi (70, 1m7): " + bmi);
            Console.WriteLine($"Bmi (70, 1m7): {bmi}"); //interpolation
            Console.WriteLine($"Bmi (70, 1m7): {BmiCaculator.GetBmi(70, 1.7)}"); //interpolation

        }
    }
}
