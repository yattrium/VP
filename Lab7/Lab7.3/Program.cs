using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int B;
            bool x = true;
            Console.WriteLine("введите B");
            B = Convert.ToInt32(Console.ReadLine());
            x = ((B % 2 == 0) && ((B >9)&&(B<100)));
            if (x)
            { Console.WriteLine("верно - Данное число является четным двузначным"); }
            else
            { Console.WriteLine("неверно - Данное число не является четным двузначным"); }
            Console.ReadLine();

        }
    }
}
