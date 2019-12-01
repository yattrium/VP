using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._1
{
    class Program
    {
        /*Описать функцию PowerA3(A, B), вычисляющую третью степень числа A и возвращающую ее в 
         * переменной B (A — входной, B — выходной параметр; оба параметра являются вещественными). 
         * С помощью этой функции найти третьи степени пяти данных чисел.*/
        static void PowerA3(double A, out double B)
        {
            B = Math.Pow(A,3);
        }
        static void Main(string[] args)
        {
            double b;
            for(int i = 2; i < 7; i++)
            {
                PowerA3(i, out b);
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
