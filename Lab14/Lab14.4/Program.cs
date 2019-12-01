using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._4
{
    class Program
    {
        /*Дан массив размера N. Найти номер его последнего локального максимума 
         * (локальный максимум — это элемент, который больше любого из своих соседей).*/

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
                if (Arr[k]>Arr[k-1]&&Arr[k]>Arr[k+1])
                { a = Arr[k]; }
            }

            Console.WriteLine("последний локальный максимум" + a);
            Console.ReadLine();
        }
    }
}
