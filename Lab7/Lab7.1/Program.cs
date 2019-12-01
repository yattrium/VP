using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            bool x = true;
            Console.WriteLine("введите А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите B");
            B = Convert.ToInt32(Console.ReadLine());
            x = (A > 2) && (B <= 3);
            if (x)
            { Console.WriteLine("верно - Справедливы неравенства A > 2 и B =< 3");}
            else
            { Console.WriteLine("неверно - неравенства A > 2 и B =< 3 не справедливы");}
            Console.ReadLine();
        }
    }
}
