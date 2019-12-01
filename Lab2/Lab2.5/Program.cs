using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, x3,y3, P, p, S,a,b,c;
            Console.WriteLine("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2=");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2=");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x3=");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y3=");
            y3 = Convert.ToDouble(Console.ReadLine());

            a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            c = Math.Sqrt(Math.Pow((x1 - x3),2) + Math.Pow((y1 - y3),2));
            P = a + b + c;
            p = P / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("площадь=" + S);
            Console.WriteLine("периметр=" + P);

            Console.ReadLine();

        }
    }
}
