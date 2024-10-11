using StudentManagerV3EmptyConstructor.Entites;

namespace StudentManagerV3EmptyConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // neu khuon class khong co pheu/constructor
            // ta van lay duoc khuon ra duc, duc duoc 1 object rong, object chua khong khi ben trong
            // giong ta di photo 1 cai form, chua dien, tu tu dien vao
            // JAVA, C# cung cap cho ban 1 cai constructor, pheu khong lam gi ca, khong dau vao
            // photo 1 cai form trong, tu tu dien
            // Photo dc, new dc, khong lam gi them, tu tu dien vao

            // object trong tron, giong to giay, form trong
            // dien tu tu sau, tuong ung ham set()
            // Set() den dau minh xem den do, ham Get()
            // object luon duoc tao ra 

            // Java, C# tu tao giup constructor rong

            Student s1 = new Student(); // contruuctor tu sinh ra, empty constructor, default constructor - khong dau, khong lenh do vao field
            Console.WriteLine(s1);
            Console.WriteLine(s1.ToString());
            s1.ShowProfile();

            s1.SetName("An");
            s1.SetYob(2006);
            Console.WriteLine("Check s1 object after setting");
            s1.ShowProfile();

        }
    }
}
