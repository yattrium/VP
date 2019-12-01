using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int K,N;
            Console.WriteLine("введите день");
            K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите, каким днем недели было 1 января");
            N= Convert.ToInt32(Console.ReadLine());
            K = ((K+N-2) % 7)+1;
            Console.WriteLine("номер дня недели - " + K);
            Console.ReadLine();

        }
    }
}
