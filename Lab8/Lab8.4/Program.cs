using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("введите кооринаты точки");
            Console.WriteLine("введите х");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите y");
            y = Convert.ToInt32(Console.ReadLine());
            if ((x == 0) && (y == 0)) { Console.WriteLine("точка лежит в начале координат"); }

            if ((x==0)||(y==0)) { Console.WriteLine("точка лежит на координатной прямой"); }

            if ((x > 0) && (y > 0)) { Console.WriteLine("точка в первой четверти"); }
            else
            {
                if ((x < 0) && (y > 0)) { Console.WriteLine("точка во второй четверти"); }
                else
                {
                    if ((x < 0) && (y > 0)) { Console.WriteLine("точка в третьей четверти"); }
                    else { Console.WriteLine("точка в первой четверти"); }
                }
            }
            Console.ReadLine();

        }
    }
}
