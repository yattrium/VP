using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("введите количество секунд");
            N = Convert.ToInt32(Console.ReadLine());
            
            while (N>=60)
            {
                N %= 60; 
            }

            Console.WriteLine("секунд прошедших с начала последней минуты" + N);
            Console.ReadLine();

        }
    }
}
