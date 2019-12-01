using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("введите А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите В");
            B = Convert.ToInt32(Console.ReadLine());

            while (A>=B)
            {
                A = A - B;
            }
            Console.WriteLine("длина незанятой части отрезка A " + A);

            Console.ReadLine();
        }
    }
}
