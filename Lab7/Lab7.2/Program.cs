using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B,C;
            bool x = true;
            Console.WriteLine("введите А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите C");
            C = Convert.ToInt32(Console.ReadLine());
            x = ((A<B)&&(B<C)) ;
            if (x)
            { Console.WriteLine("верно - Справедливо двойное неравенство A < B < C"); }
            else
            { Console.WriteLine("неверно - двойное неравенство A < B < C не справедливо"); }
            Console.ReadLine();
        }
    }
}
