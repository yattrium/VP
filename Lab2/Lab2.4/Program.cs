using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, P,S;
            Console.WriteLine("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2=");
            x2 = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("y2=");
            y2 = Convert.ToDouble(Console.ReadLine());
            P = (Math.Abs(y1 - y2) + Math.Abs(x1 - x2)) * 2;
            S = Math.Abs(y1 - y2) * Math.Abs(x1 - x2);
            Console.WriteLine("площадь=" + S);
            Console.WriteLine("периметр=" + P);

            Console.ReadLine();

        }
    }
}
