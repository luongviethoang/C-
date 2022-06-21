using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btClassOffLine
{
    internal class Btvn4
    {
        static void Main()
        {
            Console.WriteLine("nhap bang cuu chuong cua so can tim: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap gioi han cua bang cuu chuong: ");
            int j = Convert.ToInt32(Console.ReadLine());

            for(int a = i; a <= i; a++)
            {
                for(int b = 1; b <= j; b++) 
                { Console.WriteLine($"{a} * {b} = {a*b}"); }
            }
        }
    }
}
