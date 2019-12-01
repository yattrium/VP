using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("введите А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите B");
            B = Convert.ToInt32(Console.ReadLine());

            if (A != B)
            {
                if (A > B) { B = A; } else { A = B; }
            }
            else
            {
                A = 0; B = 0;
            }

            Console.WriteLine("A=" + A);
            Console.WriteLine("B=" + B);
            Console.ReadLine();


        }
    }
}
