namespace Bmi
{
    /// <summary>
    /// class doc : short description about this class, what it will do,...
    /// </summary>
    public class BmiCaculator
    {
        // Quy ước đặt tên method
        //C# đặt tên hàm theo công thức Verb + Object 
        // Dùng cú pháp PASCAL - Pascal Case Notation - Chữ hoa từng đầu từ eg: GetYob() GetName(),...
        /// <summary>
        /// return Bmi base on weight and height. It arrange about 18.5 - 24.9 
        /// </summary>
        /// <param name="weight">Cân nặng đo bằng cân</param>
        /// <param name="height">Chiều cao đo bằng mét</param>
        /// <returns></returns>
        //static double GetBmi(double weight, double height)
        //{
        //    return weight / (height * height);
        //}

        public static double GetBmi(double weight, double height) => weight / (height * height);
        // Short hand if only have 1 command into class. Which allow skip return and brackets
        // That can be called : Expression body, expression bodied

        public static void PrintBmiMessage() => Console.WriteLine("BMI stands for Body Mass Index");
    }
}
