using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, S, P, C, L, d;
            const double pi = 3.14;
            Console.WriteLine("введите сторону a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите сторону b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите диаметр окружности");
            d = Convert.ToInt32(Console.ReadLine());
            S = a * b;
            P = 2 * (a + b);
            C = (a + b) / 2;
            L = pi * d;
            Console.WriteLine("площадь=" + S);
            Console.WriteLine("периметр=" + P);
            Console.WriteLine("среднее арифметическое=" + C);
            Console.WriteLine("диаметр=" + L);
            Console.ReadLine();
        }
    }
}
