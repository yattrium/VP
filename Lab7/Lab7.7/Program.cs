using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            bool x = true;
            Console.WriteLine("введите А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите C");
            C = Convert.ToInt32(Console.ReadLine());
            x = ((A + B) > C) && ((A + C) > B) && ((B + C) > A);
            if (x)
            { Console.WriteLine("верно - треугольник существует"); }
            else { Console.WriteLine("неверно - треугольник не существует"); }
            Console.ReadLine();
        }
    }
}
