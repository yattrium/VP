using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s, p, c, r, s1, p1, c1, r1;
            Console.WriteLine("введите число a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число b");
            b = Convert.ToInt32(Console.ReadLine());
            s = a * a + b * b;
            r = a * a - b * b;
            p = (a * a) * (b * b);
            c = (a * a) / (b * b);

            s1 = Math.Abs(a) + Math.Abs(b);
            r1 = Math.Abs(a) - Math.Abs(b);
            p1 = Math.Abs(a) * Math.Abs(b);
            c1 = Math.Abs(a) / Math.Abs(b);

            Console.WriteLine("сумма квадратов чисел=" + s);
            Console.WriteLine("разность квадратов чисел=" + r);
            Console.WriteLine("произведение квадратов чисел=" + p);
            Console.WriteLine("частное квадратов чисел=" + c);

            Console.WriteLine("сумма модулей=" + s1);
            Console.WriteLine("разность модулей=" + r1);
            Console.WriteLine("произведение модулей=" + p1);
            Console.WriteLine("частное модулей=" + c1);

            Console.ReadLine();
        }



     }
}
