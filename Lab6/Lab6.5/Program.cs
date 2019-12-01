using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("введите год");
            A = Convert.ToInt32(Console.ReadLine());
            A = (A - 1) / 100 + 1;
            Console.WriteLine("век:" + A);
            Console.ReadLine();
        }
    }
}
