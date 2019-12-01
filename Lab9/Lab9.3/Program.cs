using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._3
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int N,o,t;
            Console.WriteLine("введите количество заданий");
            N = Convert.ToInt32(Console.ReadLine());
            o = N % 10;
            t = N / 10;

            if (N > 10 && N < 20)
            {
                switch (N)
                {
                    case 11: Console.WriteLine("одиннадцать"); break;
                    case 12: Console.WriteLine("двеннадцать"); break;
                    case 13: Console.WriteLine("тринадцать"); break;
                    case 14: Console.WriteLine("четырнадцать"); break;
                    case 15: Console.WriteLine("пятнадцать"); break;
                    case 16: Console.WriteLine("шестнадцать"); break;
                    case 17: Console.WriteLine("семнадцать"); break;
                    case 18: Console.WriteLine("восемнадцать"); break;
                    case 19: Console.WriteLine("девятнадцать"); break;
                }
            }
            else
            {

                switch (t)
                {
                    case 2: Console.WriteLine("двадцать"); break;
                    case 3: Console.WriteLine("тридцать"); break;
                    case 4: Console.WriteLine("сорок"); break;
                    default: Console.WriteLine("десять"); break;
                }

                switch (o)
                {
                    case 1: Console.WriteLine("один"); break;
                    case 2: Console.WriteLine("два"); break;
                    case 3: Console.WriteLine("три"); break;
                    case 4: Console.WriteLine("четыре"); break;
                    case 5: Console.WriteLine("пять"); break;
                    case 6: Console.WriteLine("шесть"); break;
                    case 7: Console.WriteLine("семь"); break;
                    case 8: Console.WriteLine("восемь"); break;
                    case 9: Console.WriteLine("девять"); break;
                }
            }

            if (N / 1 == 0) { Console.WriteLine("учебное задание"); }
            else
            { if ((N % 10 == 2) || (N % 10 == 4)|| (N % 10 == 3)) { Console.WriteLine("учебных задания"); } else { Console.WriteLine("учебных заданий"); } }

            Console.ReadLine();
        }
    }
}
