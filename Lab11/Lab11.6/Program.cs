using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Дано целое число N (> 1), являющееся числом Фибоначчи: N = FK. 
             * Найти целое число K — порядковый номер числа Фибоначчи N.*/

            int N,a,b,c,K;
            Console.WriteLine("введите число Фибаначчи");
            N = Convert.ToInt32(Console.ReadLine());
            a = 1;//первое число 
            b = 1;//второе число
            c = 0;
            K = 0;//счетчик
            while (b<=N)
            {
                c = b;
                b = a + b;
                a = c;
                K++;
            }
            Console.WriteLine("номер числа N " + (K+1));
            Console.ReadLine();

        }
    }
}
