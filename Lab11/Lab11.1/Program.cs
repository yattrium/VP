using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Даны целые положительные числа A и B(A<B). 
            Вывести все целые числа от A до B включительно; при этом каждое число должно выводиться
                столько раз, каково его значение(например, число 3 выводится 3 раза). */

            int A, B,c;
            Console.WriteLine("введите А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите В");
            B = Convert.ToInt32(Console.ReadLine());

            for (; A<=B; A++)
            {
                for (c = 1; c <= A; c++)
                {
                    Console.Write(A);
                }
            }
            Console.ReadLine();
        }
    }
}
