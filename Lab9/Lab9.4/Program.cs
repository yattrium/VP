using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,o,t,h,h1;
            Console.WriteLine("введите число 100-999 ");
            N = Convert.ToInt32(Console.ReadLine());
            o = N % 10;
            t= (N % 100)/10;
            h = N / 100;
            h1 = N - (h * 100);
            switch (h)
            {
                case 1: Console.Write("сто "); break;
                case 2: Console.Write("двести "); break;
                case 3: Console.Write("триста "); break;
                case 4: Console.Write("четыреста "); break;
                case 5: Console.Write("пятьсот "); break;
                case 6: Console.Write("шестьсот "); break;
                case 7: Console.Write("семьсот "); break;
                case 8: Console.Write("восемьсот "); break;
                case 9: Console.Write("девятьсот "); break;
                default: Console.Write("ошибка"); break;
            }
            if (h1>10&&h1<20)
            {
                switch(h1)
                {
                    case 11: Console.Write("одиннадцать"); break;
                    case 12: Console.Write("двеннадцать"); break;
                    case 13: Console.Write("тринадцать"); break;
                    case 14: Console.Write("четырнадцать"); break;
                    case 15: Console.Write("пятнадцать"); break;
                    case 16: Console.Write("шестнадцать"); break;
                    case 17: Console.Write("семнадцать"); break;
                    case 18: Console.Write("восемнадцать"); break;
                    case 19: Console.Write("девятнадцать"); break;
                }
            }
            else
            {
                switch (t)
                {
                    case 2: Console.Write("двадцать "); break;
                    case 3: Console.Write("тридцать "); break;
                    case 4: Console.Write("сорок "); break;
                    case 5: Console.Write("пятьдесят "); break;
                    case 6: Console.Write("шестьдесят "); break;
                    case 7: Console.Write("семдесят "); break;
                    case 8: Console.Write("восемьдесят "); break;
                    case 9: Console.Write("девяносто "); break;
                }

                switch (o)
                {
                    case 1: Console.Write("один"); break;
                    case 2: Console.Write("два"); break;
                    case 3: Console.Write("три"); break;
                    case 4: Console.Write("четыре"); break;
                    case 5: Console.Write("пять"); break;
                    case 6: Console.Write("шесть"); break;
                    case 7: Console.Write("семь"); break;
                    case 8: Console.Write("восемь"); break;
                    case 9: Console.Write("девять"); break;
                }
            }

            Console.ReadLine();


        }


        
    }
}
