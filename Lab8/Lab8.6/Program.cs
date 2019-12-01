using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("введите число А");
            A = Convert.ToInt32(Console.ReadLine());

            if (A>=100) { Console.WriteLine("число трехзначное"); }
            else
            {
                if (A >= 10) { Console.WriteLine("число двухзначное"); }
                else { Console.WriteLine("число однозначное"); }
            }

            if (A % 2 == 0) { Console.WriteLine(" четное"); }
            else { Console.WriteLine(" нечетное"); }

            Console.ReadLine();

        }
    }
}
