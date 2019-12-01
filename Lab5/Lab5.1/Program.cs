using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = Convert.ToInt32(Console.ReadLine());

            x /=  1024;

            Console.WriteLine("полных килобайт:" + x);
            Console.ReadLine();


        }
    }
}
