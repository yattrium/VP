using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, D = 1, F = 0;
            int N;
            Console.WriteLine("введите N");
             N=Convert.ToInt32(Console.ReadLine());
            
            for ( i = 1; F <= N; i+= 0.1)
            {
                D = D * i;
                F = F + 1;
                Console.WriteLine(D);
            }
            Console.ReadLine();
        }
    }
}
