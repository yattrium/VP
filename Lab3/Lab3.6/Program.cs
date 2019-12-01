using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, x;
            Console.WriteLine("введите A");
            A = Convert.ToInt32(Console.ReadLine());
            x = A*A;
            x = x * x;
            x = x * x;
            Console.WriteLine("A^8=" + x);
            Console.ReadLine();






        }
    }
}
