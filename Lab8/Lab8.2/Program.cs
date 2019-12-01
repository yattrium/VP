using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("введите a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите c");
            c = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                if (b>c) { Console.WriteLine("сумма наибольших чисел" + (a +b )); }
                else { Console.WriteLine("сумма наибольших чисел" + (a +c )); }
            }
            else
            {
                if (c>a) { Console.WriteLine("сумма наибольших чисел" + ( c+b )); }
                else { Console.WriteLine("сумма наибольших чисел" + (b + a)); }
            }
            Console.ReadLine();
            
            

            
            Console.ReadLine();


        }
    }
}
