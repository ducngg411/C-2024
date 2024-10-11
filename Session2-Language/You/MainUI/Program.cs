namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
            {
            GetBMI();
            }
            static void GetBMI()
            {
                double weight = 70;
                double height = 1.7;
                double bmi = weight / (height * height);
                Console.WriteLine($"BMI (w: {weight} | h: {height}: {bmi}");
            }
    }
}

