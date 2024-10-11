using Poem.XuanQuynh;

namespace Poem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTyAy();
            Useverbatin();
            Song.PrintSongCode();
        }

        // có câu: static chơi với static 
        static void PrintTyAy()
        {
            int year = 2024; // Khai báo biến dùng ký pháp camel case notaion - cú pháp con lạc đà 
            // ví dụ: salary, basicSalary

            int month = 05; 

            Console.WriteLine("Year: " + year +" "+ month); // ghép chuỗi style truyền thống - string concatenated dùng dấu + 
            Console.WriteLine("Từ ấy trong tôi bừng nắng hạ");

            Console.WriteLine("Year: {0} | {1}", year,month); // place-holder - điền vào chỗ trống

            Console.WriteLine($"Year: {year} | {month}"); //interpolation 

            //Console.WriteLine("Từ ấy trong tôi bừng nắng hạ");
            //Console.WriteLine("Mặt trời chân lí chói qua tim");
            //Console.WriteLine("Hồn tôi là một vườn hoa lá");
            //Console.WriteLine("Rất rộn hương và rộn tiếng chim");

            //Console.WriteLine("Từ ấy trong tôi bừng nắng hạ\nMặt trời chân lí chói qua tim\nHồn tôi là một vườn hoa lá\nRất rộn hương và rộn tiếng chim");

//            Console.WriteLine(@"TỪ ẤY

//Từ ấy trong tôi bừng nắng hạ
//Mặt trời chân lí chói qua tim
//Hồn tôi là một vườn hoa lá
//Rất rộn hương và rộn tiếng chim"); //@ biến chuôi thành chuỗi nguyên bản - có kí tự gì sẽ bên rong chuỗi lúc edit 
                                   // Có \n thì in \
                                   // Goi la Verbatin


//            Console.WriteLine(@"
//<html>
//    <head>

//    </head>

//    <body>

//    </body>

//</html>
//");


        }

        static void Useverbatin()
        {
            string path = @"C:\SU24\news";
            string path_2 = @"D:\SU24\news";
            Console.WriteLine($@"path: {path} \ {path_2}");
        }

    }
}
