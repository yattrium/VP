using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._1
{
    class Program
    {
        /*Дано целое число N (> 0). Сформировать и вывести целочисленный массив размера N, 
         * содержащий N первых положительных нечетных чисел: 1, 3, 5, . . . .*/

        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int N;
            N = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[N];
            int k = 0;
            for (int i = 1; k < N; i++)
            {
                if (i % 2 == 1)
                {
                    Arr[k] = i;
                    Console.Write(Arr[k] + " ");
                    k++;
                }
            }
            Console.ReadLine();


        }
    }
}
