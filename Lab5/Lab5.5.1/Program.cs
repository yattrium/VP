using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;
            Console.WriteLine("введите трехзначное число");
            x = Convert.ToInt32(Console.ReadLine());
            a = x / 100;
            b = x % 100;
            x = (b * 10) + a;
            Console.WriteLine("x=" + x);
            
            Console.ReadLine();
        }
    }
}
