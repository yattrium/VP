using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string[] day = new string[31] { "первое", "второе", "третье", "четвертое", "пятое", "шестое", "седьмое", "восьмое", "девятое", "десятое", "одиннадцатое", "двенадцатое", "тринадцатое", "четырнадцатое", "пятнадцатое", "шестнадцатое", "семнадцатое", "восемнадцатое", "девятнадцатое", "двадцатое", "двадцать первое", "двадцать второе", "двадцать третье", "двадцать четвертое", "двадцать пятое", "двадцать шестое", "двадцать седьмое", "двадцать восьмое", "двадцать девятое", "тридцатое", "тридцать первое" };
            string[] year = new string[12] { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            Console.WriteLine("введите номер дня");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите номер месяца");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(day[A - 1]+" " + year[B-1]);

            Console.ReadLine();
        }
    }
}
