using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,W;
            Console.WriteLine("введите цену 1кг");
            A = Convert.ToDouble(Console.ReadLine());
           
            for ( W= 1; W <= 10; W++)
            {
                Console.WriteLine("цена " + (W / 10) + "киллограма конфет равна " + ((W * A) / 10));
               
            }
            Console.ReadLine();

        }
    }
}
