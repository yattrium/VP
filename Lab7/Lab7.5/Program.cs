using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, a, b, c,d;
            bool x = true;
            Console.WriteLine("введите четырехзначное число");
            A = Convert.ToInt32(Console.ReadLine());
            a = A / 1000; //вывод первого числа           
            d = A % 10; //вывод четвертого числа
            c = ((A % 100) - d) / 10; //вывод третьего числа    
            b = ((A % 1000) - (((A % 100) - d))-d)/100; //вывод второго числа
            x = (a == d) && (b == c);
            if (x)
            { Console.WriteLine("верно - Данное число читается одинаково слева направо и справа налево"); }
            else { Console.WriteLine("неверно - Данное число не читается одинаково слева направо и справа налево"); }
            Console.ReadLine();
        }
    }
}
