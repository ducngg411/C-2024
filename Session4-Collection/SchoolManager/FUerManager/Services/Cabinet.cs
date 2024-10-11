using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManager.Services
{
    public class Cabinet<T> // type tui se luu tru va xu li 1 dam T nao do, mang T[] nao do, List<T> nao do, 
                            // T co the la student 
    {
        //private T[] _arr; // = new T[30], size neu qua constructor
        //int _count = 0;

        private List<T> _arr = new(); // khong can constructor de truyen size vao, tu noi com thach sach, tui ba gang
        //
        public void PrintItems()
        {
            if (_arr.Count == 0)
            {
                Console.WriteLine("The list is empty. Nothing ");
                return;
            }

            Console.WriteLine($"There is/are {_arr.Count} items(s) in the list");
            foreach (T item in _arr)
            {
                Console.WriteLine(item);
            }
        }

        public void AddItem(T item)
        {
            // validation here, vi du kiem tra id trung
            _arr.Add(item); // _arr[count++] = x
        }

        public void RemoveItem(T item)
        {
            _arr.Remove(item);
        }

    }
}
