using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,D,i;
            Console.WriteLine("введите N");
            N = Convert.ToInt32(Console.ReadLine());
            D = 0;
            for (i = 1; i <= N; i++)
            {
                D= D + 2 * i - 1;
                Console.WriteLine(D);
            }
            Console.ReadLine();

        }
    }
}
