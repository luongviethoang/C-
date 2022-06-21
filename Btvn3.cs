using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btClassOffLine
{
    internal class Btvn3
    {
       int dayOfWeek = Convert.ToInt32(Console.ReadLine());
            switch (dayOfWeek)
            {
                case 2:
                    Console.WriteLine("hom nay la thu 2");
                    break;  
                case 3:
                    Console.WriteLine("hom nay la thu 3");
                    break ;
                case 4:
                    Console.WriteLine("hom nay la thu 4");
                    break;
                default:
                    break;
            }
}
}
