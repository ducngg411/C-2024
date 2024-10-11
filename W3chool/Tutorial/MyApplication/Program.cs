namespace MyApplication
{
    class Car
    {
        string color = "red";
    
        static void Main(string[] args)
        {
        Car volvoCar = new Car();
        Console.WriteLine(volvoCar.color);
        }
    }
    class Animals
    {
        string name = "Peter";
        static void Main(string[] args)
        {
            Animals animals = new Animals();
            Console.WriteLine(animals.name);
        }
    }
}
