using System.Diagnostics.CodeAnalysis;

namespace ArrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithIntergerListV6();
        }

        static void PlayWithIntergerListV6()
        {
            int a = 10;
            int b = a;
            int[] arr1 = { 5, 10, 15, 20 };

            int[] arr2 = { 2, 4, 6, 8 };

            Console.WriteLine("arr2 at first ...");
            foreach (int x in arr2)
            {
                Console.WriteLine(x + " ");
            }

            Console.WriteLine();

            arr2 = arr1;

            Console.WriteLine("arr2 after assigning to the ...");
            foreach (int x in arr2)
            {
                Console.WriteLine(x + " ");
            }

            Console.WriteLine();

            static void PlayWithIntergerListV5()
            {
                int[] arr = new int[10]; // 10 element, 10 phan tu, 10 bien int le nay duoc gom chung trong ten arr

                // co 11 bien: 1 ma mi 
                arr[0] = 5;
                arr[1] = 10;
                arr[2] = 15;
                arr[3] = 20;

                // gan truoc 4 gia tri cho 4 bien dau, hoi rang 6 bien con lai la may??
                // vung 6 bien int con lai se mang default - object la vay, khong dien du info la mang default 

                Console.WriteLine("This list of numbers");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]} ");
                }

                Console.WriteLine(@"
This list of numbers");

                foreach (int x in arr)
                {
                    Console.Write($"{x} ");
                }

            } // chot ha: mang la khai bao nhieu bien cung luc cung kieu cung ten, o sat nhau trong ram
              // vay thi gan gia tri cho nhieu bien thi loi tung bien [i] ra = value
              // thuong mang se luon chua day, moi bien se chua duoc gan value 
              // choi voi mang ta hay - luon for den count - count la 1 bien dem dung luu so luong bien dang co value !!!
              // count = 4, mang co 10 bien, biet ngay co 6 bien se can gan value 

            static void PlayWithIntegerListV4()
            {
                int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };

                foreach (int x in arr)
                { // voi x roi vao in tap arr, thi x co the = arr[0], x = arr[1], x = arr[i] - toan tu voi moi trong tap hop toan hoc 
                  // choi voi x chinh la choi voi arr[i]
                    Console.WriteLine($"{x}");

                }
                Console.WriteLine();

                foreach (var x in arr)
                { // voi x roi vao in tap arr, thi x co the = arr[0], x = arr[1], x = arr[i] - toan tu voi moi trong tap hop toan hoc 
                  // choi voi x chinh la choi voi arr[i]
                    Console.WriteLine($"{x}");

                }
                Console.WriteLine();

                // fore tab tab - goi y cu phap 
            }

            // Challenge 1: hay luu tru va in ra day so 5 10 15 20 25 30 35 40 45 50
            // Challenge 2: hay luu tru luong mua tung ngay cua tung nam (365 * so nam 

            // luu tru du lieu trong RAM: bien
            // luu tru du lieu lau dai: thiet bi luu tru hdd/ssd
            // cay thu muc, database 
            // can nhieu bien thi luu duoc nhieu value 
            // vi tai 1 thoi diem, 1 bien luu 1 value 

            static void PlayWithIntegerList()
            {
                // Challenge 1: hay luu tru va in ra day so 5 10 15 20 25 30 35 40 45 50
                // ki thuat trau bo - dung suc 

                //int a, b, c, d, e;
                //int f, g, h, i, j;

                //a = 5; b = 10; c = 15; d = 20; e = 25; f = 30; g = 35; h = 40; i = 45; j = 50;
                int a = 5, b = 10, c = 15, d = 20, e = 25, f = 30, g = 35, h = 40, i = 45, j = 50;

                Console.WriteLine("This list of 5 10 15 .....");
                Console.WriteLine($"{a} {b} {c} {d} {e} {f} {g} {h} {i} {j}");

                int sum = a + b + c + d + e + f + g + h + i + j;
                Console.WriteLine("Sum: " + sum);
            }



            static void PlayWithIntegerListV1()
            {
                // Khai bao si 
                // mang la ki thuat khai bao nhieu bien cung luc, cung kieu, cung ten, va o sat nhau trong ram - y chang day nha lien ke, y chang 1 tang chung cu 

                //int[] arr1; // arr1 ko phai la 1 bien int, vi co dau []
                // arr la 1 bien, khong phai bien int, ma la bien, ma la ten goi, ma len ten bien dai dien cho nhieu bien int khac 
                // tuc la arr khong mang gia tri 5 10 15 20, ma no goi la ten goi chung cho nhieu
                // bien int khac ma no nam giu, quan li
                // arr: tui goi la bien ma mi (tu ong tu ba)
                //int[] arr = 10; // Gay vi arr la am chi nhieu bien int; can them nhieu value 

                int[] arr1 = { 1 };
                int[] arr2 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

                // arr2 dai dien cho 10 bien int khac 
                // 5 la gia tri cua bien int dau tien trong 10 bien int 
                // 10 la gia tri cua bien int thu 2 trong 10 bien 

                int[] arr3 = [5, 10, 15, 20, 25, 30, 35, 40, 45, 50];

                int[] arr4 = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

                int[] arr5 = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

                int[] arr6;
                arr6 = new int[10];
                arr6[0] = 5;
                arr6[1] = 10;
                arr6[2] = 15;

                int[] arr7 = new int[10];
                arr7[0] = 5;
                arr7[1] = 10;
                arr7[2] = 15;

                // Tong quat: co 2 cach khai bao mang - khai bao nhieu bien

                // Vua khai bao vua gan Value cho tung bien/tung phan tu 

                // khai bao mang 1 cau lenh, sau do gan value cho tung phan tu, cach nay go hoi mat suc ti 

                // new int[???] : chinh la xin 1 vung new bu de chua bien khac/element

                // Vay khai bao mang theo style nao

                // Thuc te: style 2, li do ta dau biet truoc value!!
                // Luong mua trong nam chua biet het, sao gan value ngay luc khai bao mang 

                int[] arr8 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

                // [] Bieu dien ten phu, khi cac bien xai chung ten arr
                // arr -> ma mi quan li 10 dua cung ten arr phan biet bang ten phu arr[0] arr[1] arr[2] la bien int duoi truong
                // arr khong ngoac vuong: ma mi
                // ARR[] nhung dua duoi ban tay ma mi -> dua/bien luu value thuc su
                // ARR[0] la co value 5
                // ARR[1] la co value 10

                // index
                // khi choi voi mang, index i chay tu 0..9 thi ta se dung vong lap
                // choi voi lap for I [0..9]
                // ta 

            }

            static void PlayWithIntegerListV3()
            {
                int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };

                // in mang, in tung bien 

                Console.WriteLine("The list of 5..10...");
                Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]} {arr[5]} {arr[6]} {arr[7]} {arr[8]} {arr[9]}");

                Console.WriteLine("The list of 5..10 using for i");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]} ");

                }

                Console.WriteLine();

                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine("Sum new: " + sum);
            }
        }
    }
}