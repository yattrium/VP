using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20._5
{
    class Program
    {   /*Даны строки S и S0. Найти количество вхождений строки S0 в строку S*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку S ");
            string S = Convert.ToString(Console.ReadLine());
            Console.WriteLine("введите строку S0 ");
            string S0 = Convert.ToString(Console.ReadLine());
            int i = 0, k = -1, c = -1;
            while (i != -1)
            {
                i = S.IndexOf(S0, k + 1);
                k = i;
                c++;
            }
            Console.WriteLine("количество вхождений строки S0 в строку S= "+c);
            Console.ReadKey();


        }
    }
}
