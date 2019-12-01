using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("введите А");
            A = Convert.ToInt32(Console.ReadLine());
            if (A==0) { Console.Write("число равно нулю"); }
            else
            {   if (A > 0)
                {
                    if  (A % 2 == 0) { Console.WriteLine("число четное положительное"); }
                    else { Console.WriteLine("число нечетное положительное"); }      
                }
                else
                {
                    if (A % 2 == 0) { Console.WriteLine("число четное отрицательное"); }
                    else { Console.WriteLine("число нечетное отрицательное"); }
                }
            }
            Console.ReadLine();

        }
    }
}
