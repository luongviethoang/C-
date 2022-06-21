using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btClassOffLine
{
    internal class Btvn2
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(a, b), c));
        }
    }
}
