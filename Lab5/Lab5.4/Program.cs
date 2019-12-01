using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;
            Console.WriteLine("введите двухзначное число");
            x = Convert.ToInt32(Console.ReadLine());
            a = x / 10;
            b = x % 10;
            x = (b * 10) + a;
            Console.WriteLine("x=" + x);
            Console.ReadLine();

        }
    }
}
