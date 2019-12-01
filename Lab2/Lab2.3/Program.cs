using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, d1, d2, p;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            if (C > A && C < B)
            {
                d1 = Math.Abs(C - A);
                d2 = Math.Abs(C - B);
                p = d1 * d2;

                /* Console.WriteLine("d1=" + d1);
                Console.WriteLine("d2=" + d2); */
                Console.WriteLine("произведение длин отрезков=" + p);
            } else { Console.WriteLine("ошибка"); }

            Console.ReadLine();
            
        }
    }
}
