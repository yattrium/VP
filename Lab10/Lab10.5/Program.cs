using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            double A, c,b,z;
            Console.WriteLine("введите N - степень");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите А - основание");
            A = Convert.ToDouble(Console.ReadLine());
            c = 1;
            b = 1;
            z = -1;
            for (i = 1; i <= N; i++)
            {
                c = c*A*z;
                b = b + c;
            }
            Console.WriteLine("выражение равно " + b);
            Console.ReadLine();

        }
    }
}
