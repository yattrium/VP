using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._1
{
    class Program
    {
        /*Дан массив размера N и целые числа K и L (1 ≤ K ≤ L ≤ N). 
         * Найти среднее арифметическое элементов массива с номерами от K до L включительно.*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int N= Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[N];

            for (int k = 0; k < N; k++)
            {
                Console.WriteLine("введите " + k + " элемент массива");
                Arr[k] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("введите число K");
            int K= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число L");
            int L= Convert.ToInt32(Console.ReadLine());

            int A = 0;
            int B = 0;
            for (int i = 0; i < N; i++)
            {
                if ((i >= K) && (i <= L))
                {
                    B += Arr[i];
                    A++;
                }
            }
            A = B / A;
            Console.WriteLine("среднее арифметическое равно " + A);
            Console.ReadLine();
        }
    }
}
