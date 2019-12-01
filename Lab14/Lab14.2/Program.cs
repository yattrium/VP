using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._2
{
    class Program
    {
        /*Дан целочисленный массив размера N, не содержащий одинаковых чисел. 
         * Проверить, образуют ли его элементы арифметическую прогрессию. 
         * Если образуют, то вывести разность прогрессии, если нет — вывести 0.*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[N];

            for (int k = 0; k < N; k++)
            {
                Console.WriteLine("введите " + k + " элемент массива");
                Arr[k] = Convert.ToInt32(Console.ReadLine());
            }

            int d = Arr[1] - Arr[0];
            bool V = false;

            for (int i = 2; i < N && V==false; i++)
            {
                if ((d == Arr[i] - Arr[i - 1]) && (d > 0))
                {
                    Console.WriteLine("разность прогрессии " + d);
                    V = true;
                }
                else
                {
                    Console.WriteLine(0);
                }

            }
            Console.ReadLine();
        }
    }
}
