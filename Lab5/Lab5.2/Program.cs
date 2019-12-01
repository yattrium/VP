using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B,x,y;
            Console.WriteLine("введите значеие отрезка А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите значение отрезка B");
            B = Convert.ToInt32(Console.ReadLine());

            if (A>B)
                { x = A / B;
                Console.WriteLine("целых отрезков В на отрезке А:" + x);
                y = A %B;
                Console.WriteLine("незанятая часть отрезка А:"+y);
            }
            else { Console.WriteLine("error"); }

            Console.ReadLine();

        }
    }
}
