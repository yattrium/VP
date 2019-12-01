using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, V;
            Console.WriteLine("input A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input B");
            B = Convert.ToInt32(Console.ReadLine());

            V = A;
            A = B;
            B = V;

            Console.WriteLine("A=" + A);
            Console.WriteLine("B=" + B);

            Console.ReadLine();

        }
    }
}
