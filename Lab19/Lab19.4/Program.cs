using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19._4
{
    class Program
    {   /* Дана матрица размера M × N. 
        Упорядочить ее строки так, чтобы их первые элементы образовывали возрастающую последовательность.*/
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите N: ");
           int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int k;
            for (int i = 0; i < N-1; i++)
            {
                for (int j = i + 1; j < M; j++)
                {
                    if (arr[i, 1] > arr[j, 1])
                    {
                        for (int q = 0; q < N; q++)
                        {
                            k = arr[i, q];
                            arr[i, q] = arr[j, q];
                            arr[j, q] = k;
                        }
                    }

                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
            }
            Console.ReadLine();
        }
    }
}
