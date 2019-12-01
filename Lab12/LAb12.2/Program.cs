using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb12._2
{
    class Program
    {
         /*Описать функцию Sign(X) целого типа, возвращающую для вещественного числа X следующие значения:
            −1, если X < 0; 0, если X = 0; 1, если X > 0. 
            С помощью этой функции найти значение выражения Sign(A) + Sign(B) для данных вещественных чисел A и B. */
        static double Sign(double x)
        {
            return x < 0 ? -1 : x == 0 ? 0 : 1; 
        }
        static void Main(string[] args)
        {
            double A, B,c;
            Console.WriteLine("введите А");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите B");
            B = Convert.ToDouble(Console.ReadLine());

            c = Sign(A) + Sign(B);
            Console.WriteLine("значение выражения равно " + c);
            Console.ReadLine();
        }
    }
}
