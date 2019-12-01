using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, r;
            Console.WriteLine("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2=");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2=");
            y2 = Convert.ToDouble(Console.ReadLine());
            r = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("расстояние между точками="+r);
            Console.ReadLine();
        }
    }
}
