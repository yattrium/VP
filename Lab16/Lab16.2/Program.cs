using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16._2
{
    class Program
    {   /*Дан целочисленный массив размера N. Удалить из массива все элементы, 
        встречающиеся ровно два раза, и вывести размер полученного массива и его содержимое.*/
        static void Main(string[] args)
        {
            int t = 0, k = 0;
            Console.Write("Введите размер массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("введите значение элемента "+ i+" ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        k++;
                        t = j;
                    }
                }

                if (k == 2)
                {
                    for (int j = t; j < N - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    N--;

                    for (int j = i; j < N - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    N--;
                    i--;
                }

                k = 0;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("длинна массива " + N);
            Console.ReadLine();

        }
    }
}
