using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16._1
{
    class Program
    {
        /*Дан целочисленный массив размера N. 
         * Удалить из массива все соседние одинаковые элементы, оставив их первые вхождения.*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите длинну массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[N];
          
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("введите значение элемента"+ i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int k = 0;
            for (int i = 1; i < N; i++)
            {
                if (arr[k] != arr[i])
                {
                    k++;
                    arr[k] = arr[i];
                }
            }
            for (int i = 0; i < k+1; i++)
            {
                Console.Write( arr[i]);
            }

            Console.ReadLine();

            /* int k = 1;
            int prev = arr[0];
            var list = new List<int> { arr[0] };
            while (k < N)
            {
                if (arr[k] != prev)
                    list.Add(arr[k]);
                prev = arr[k];
                k++;
            }

            arr = list.ToArray();

            for (int i = 0; i < N+1; i++)
            {
                Console.WriteLine("arr " + i + "= " + arr[i]);
            } */


        }
    }
}
