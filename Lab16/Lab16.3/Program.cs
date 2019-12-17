using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16._3
{
    class Program
    {
        /*Дан массив размера N. 
         * Вставить элемент с нулевым значением перед минимальным и после максимального элемента массива.*/
        static void Main(string[] args)
        {
            int max = -10001, min = 100001, max_idex = 0, min_idex = 0, t, k = 0;
            Console.Write("Введите размер массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            int[] arr2 = new int[N + 2];

            for (int i = 0; i < N; i++)
            {
                Console.Write("введите значение элемента " + i + " ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    min_idex = i;
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    max_idex = i;
                }
            }

            for (int i = 0; i < N + 2; i++)
            {
                t = 0;
                if (k == min_idex)
                {
                    arr2[k] = 0;
                    i++;
                }
                else if (k == min_idex)
                {
                    arr2[i] = 0;
                    i++;
                }

                if (k == max_idex)
                {
                    arr2[i + 1] = 0;
                    t = 1;
                }

                if (i < N + 2 && i >= 0) arr2[i] = arr[k];
                if (t == 1) i++;
                if (k < N) k++;
            }

            for (int i = 0; i < N + 2; i++) Console.Write(arr2[i] + " ");

            Console.ReadLine();

        }
    }
}
