using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Даны целые положительные числа A и B. 
             * Найти их наибольший общий делитель (НОД), используя алгоритм Евклида */

            int A, B;
            Console.WriteLine("введите А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите B");
            B = Convert.ToInt32(Console.ReadLine());
            while (A!=B)
            {
                if (A>B) { A = A - B; } else { B = B - A; };
            }
            Console.WriteLine("НОД равен" + A);
            Console.ReadLine();
        }
    }
}
