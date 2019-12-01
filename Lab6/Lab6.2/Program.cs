using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int K;
            Console.WriteLine("введите день");
            K = Convert.ToInt32(Console.ReadLine());
            K = K % (7+1);
            Console.WriteLine("номер дня недели - " + K);
            Console.ReadLine();


        }
    }
}
