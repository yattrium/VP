using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, V;
            Console.WriteLine("введите A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите C");
            C = Convert.ToInt32(Console.ReadLine());

            V = A;
            A = C;          //меняем местами А и С
            C = V;

            V = A;
            A = B;          //меняем местами А и В
            B = V;

            Console.WriteLine("A=" + A);
            Console.WriteLine("B=" + B);
            Console.WriteLine("C=" + C);

            Console.WriteLine("введите новое значение A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите новое значение B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите новое значение C");
            C = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

        }
    }
}
