using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,K,sum;
            Console.WriteLine("введите N");
            N = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            K = 1;
            while (sum<=N)
            {
                sum = sum+K;
                K++;
            }
            Console.WriteLine("число К равно " + K + "  cумма равна " + sum);
            Console.ReadLine();
        }
    }
}
