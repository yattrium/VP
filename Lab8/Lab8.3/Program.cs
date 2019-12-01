using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,a1,b1,c1,d,e;
            Console.WriteLine("введите a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите a1");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите b1");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите c1");
            c1 = Convert.ToDouble(Console.ReadLine());
            d = Math.Sqrt(Math.Pow((a1 - a), 2) + Math.Pow((b1 - b), 2));
            e = Math.Sqrt(Math.Pow((a1 - a), 2) + Math.Pow((b1 - b), 2));
            if (d < e) { Console.WriteLine("расстояние между точками B и А=" + d); }
            else
            {
                if (e > d) { Console.WriteLine("расстояние между точками C и А=" + e); }
                else { Console.WriteLine("расстояние между точками одинаково" + d); }
            }
                Console.ReadLine();
        }
    }
}
