using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("введите x");
            x = Convert.ToDouble(Console.ReadLine());
            y = 4 * (Math.Pow((x-3), 6)) - 7 * (Math.Pow((x-3), 3)) +2;
            Console.WriteLine("y=" + y);

            Console.ReadLine();
        }
    }
}
