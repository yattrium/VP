using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16._4
{
    class Program
    {   /*Дан массив размера N. 
        После каждого отрицательного элемента массива вставить элемент с нулевым значением.*/
        static void Main(string[] args)
        {
           
            Console.Write("введите размер массива ");
            int N = Convert.ToInt32(Console.ReadLine());
            int c = 0,k=0;
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("введите значение элемента " + i + " ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] < 0) c++;
            }

            int[] arr2 = new int[N + c];

            for (int i = 0; i < N; i++)
            {
                arr2[i] = arr[i];
            }
            for (int i = 0; i < c; i++)
            {
                arr2[i + N] = 0;
            }

            for (int i = 0; i < N + c; i++)
            {
                if (arr2[i] < 0)
                {
                    for (int j = N + k; j > i + 1; j--)
                    {
                        int var = arr2[j];
                        arr2[j] = arr2[j - 1];
                        arr2[j - 1] = var;
                    }
                    k++;
                }
            }

            for (int i = 0; i < N+c; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.ReadLine();

        }
    }
}
