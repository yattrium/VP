using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._3
{
    class Program
    {
        /*Дан массив A размера N. Найти минимальный элемент из его элементов с четными номерами: A2, A4, A6,*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[N];
            int a = 0;
            for (int k = 0; k < N; k++)
            {
                Console.WriteLine("введите " + k + " элемент массива");
                Arr[k] = Convert.ToInt32(Console.ReadLine());                
            }

            for (int k = 0; k < N; k++)
            {
                if (k == 2)
                {
                    a = Arr[k];
                }
                if ((k % 2 == 0) && (a > Arr[k]))
                {
                    a = Arr[k];
                }
            }
            Console.WriteLine("наименьший элемент массива равен " + a);
            Console.ReadLine();
        }
    }
}
