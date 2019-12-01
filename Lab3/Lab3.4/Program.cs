using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("введите x");
            x = Convert.ToDouble(Console.ReadLine());
            y = 3 * (Math.Pow(x, 6)) - 6 * (Math.Pow(x, 2)) - 7;
            Console.WriteLine("y=" + y);

            Console.ReadLine();


        }
    }
}
