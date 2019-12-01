using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, a, b, c;
            bool x = true;
            Console.WriteLine("введите трехзначное число");
            A = Convert.ToInt32(Console.ReadLine());
            a = A / 100; //вывод первого числа
            c = A % 10; //вывод третьего числа
            b = ((A % 100) - c)/10; //второе число
            x = ((a < b) && (b < c)) || ((a > b) && (b > c));
            if (x)
            { Console.WriteLine("верно - Цифры данного числа образуют возрастающую или убывающую последовательность"); } 
            else { Console.WriteLine("неверно - Цифры данного числа не образуют возрастающую или убывающую последовательность"); }
            Console.ReadLine();


        }
    }
}
