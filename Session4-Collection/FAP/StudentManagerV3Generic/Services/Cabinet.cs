using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3Generic.Services
{
    public class Cabinet <T>
    {
        private T[] _arr; // T:Type, datatype, se la bat ki student, lecturer, tiger, cac loai data type, class khac dua vao
        private int _count;

        public Cabinet(int size) => _arr = new T[size];

        public void PrintAnItems()
        {
            if (_count <= 0)
            {
                Console.WriteLine("There is nothing to show!");
                return;
            }

            else
            {
                Console.WriteLine($"There is/are {_count} item(s) in the cabinet");

                for (int i = 0; i < _count; i++)
                {
                    Console.WriteLine(_arr[i]);
                }
            }
        }

        public void AddAnItem(T x) 
        {

            if (_count == _arr.Length)
            {
                Console.WriteLine("Out of range to print!");
            } 

            else  
            {
                _arr[_count++] = x;
            }
        
        
        } 
        
        


        
    }
}
