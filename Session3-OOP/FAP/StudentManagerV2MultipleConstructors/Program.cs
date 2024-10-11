using StudentManagerV2MultipleConstructors.Entities;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;

namespace StudentManagerV2MultipleConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("SE1", "Nguyen Trong Duc", 2004, 8.6);
            Student s2 = new Student("SE2", "Nguyen Trong Duc");
            var s3 = new Student("SE3", "Cuong");
            Console.WriteLine("S3 details with default values inside");
            Console.WriteLine(s3);

            s3.SetYob(2005);
            s3.SetGpa(9.9);
            Console.WriteLine("s3 detail after setting");
            Console.WriteLine(s3);


            Student s4 = new Student("SE4", "Dung Standard", 2005, 9.2);
            //New tra ve toa do, tra ve dia chi can nha bu trong ram
            //Tra ve dia chi vung new, byte thu may trong ram
            //s4 goi la 
            s4.ShowProfile();

            new Student("SE4", "Dung", 2005, 9.2).ShowProfile(); // khong co tham chieu, dung duoc 1 lan duy nhat,
                                                                 // object mo coi (anonymous object)
                                                                 // object tao ra khong co bien de moc vao tham chieu lau dai
                                                                 // ta khong co co hoi giut giut soi day nhieu lan
                                                                 // vung new duoc tao ra ma khong co bien de moc vao
                                                                 // vi vua new la co toa do, cham duoc ngay 
                                                                 // sau do khong luu toa do lau dai, lam sao cham tiep
                                                                 // vung ram khong co con tro moc vao, choi tro nay mau het ram, leak memory
                                                                 // cho nen java va c# co 1 co che giam sat vung ram, runtime co 1 doan code 
                                                                 // nho nho dinh ki quet vung ram
        }
    }
}
