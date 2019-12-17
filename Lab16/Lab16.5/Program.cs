using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16._5
{
    class Program
    {   /*Дан массив размера N. 
        Перед каждым положительным элементом массива вставить элемент с нулевым значением.*/
        static void Main(string[] args)
        {
            Console.Write("введите размер массива ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[100];
            //int k=0,p=0;
            for (int i = 0; i < N; i++)
            {
                Console.Write("введите значение элемента " + i + " ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
               // if (arr[i] > 0) k++;
            }
           // int[] arr2 = new int[N + k];

            for (int i = N - 1; i >= 0; i--)
            {
                if (arr[i] > 0)
                {
                    N++;
                    for (int j = N - 1; j > i; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[i] = 0;
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
