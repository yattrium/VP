using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, d1, d2, s;
            A=Convert.ToInt32(Console.ReadLine());
            B=Convert.ToInt32(Console.ReadLine());
            C=Convert.ToInt32(Console.ReadLine());
            d1 = Math.Abs(C - A);
            d2 = Math.Abs(C - B);
            s = d1 + d2;
            Console.WriteLine("длинна отрезка АС=" + d1);
            Console.WriteLine("длинна отрезка ВС=" + d2);
            Console.WriteLine("сумма отрезков=" + s);
            Console.ReadLine();


        }
    }
}
