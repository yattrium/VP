using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, x,y;
            Console.WriteLine("введите A");
            A = Convert.ToInt32(Console.ReadLine());
            x = A * A;
            y = A * x;
            y = x * y;
            x = y * y;
            x = x * y;
            Console.WriteLine("A^15=" + x);
            Console.ReadLine();
        }
    }
}
