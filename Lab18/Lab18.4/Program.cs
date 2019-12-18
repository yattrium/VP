using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._4
{
    class Program
    {   /*Дана матрица размера M × N. В каждом ее столбце найти количество элементов, 
        больших среднего арифметического всех элементов этого столбца*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите N");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите M");
            int M = Convert.ToInt32(Console.ReadLine());
            int i, j;
            int[,] arr = new int[M, N];
            double[] average = new double[N];
            Console.WriteLine("введите элементы матрицы ");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.WriteLine("A[{0},{1} ] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            double av = 0, k = 0;

            for ( i = 0; i < M; i++)
            {
                int sum = 0;
                for ( j = 0; j < N; j++)
                {
                    sum += arr[j, i];
                }
                av = sum / M;
                average[i] = av;
            }

            for ( i = 0; i < N; i++)
            {
                k = 0;
                for ( j = 0; j < N; j++)
                {
                    if (average[i] < arr[j, i])
                    {
                        k++;
                    }
                }
                Console.WriteLine("в {0} столбце,количество элементов больших среднего значение = {1} ", i, k);
            }

            /* for (i = 0; i < N; i++)
             {
                 av = 1;
                 for (j = 0; j < M; j++)
                 {
                     av =(av+ arr[j, i])/M;
                     average[i] = av;
                 }
             }

             for (i = 0; i < N; i++)
             {
                 for (j = 0; j < M; j++)
                 {
                     if (arr[j, i] > average[i]) { k++; }
                 }
                 Console.WriteLine("столбец {0}: количество элементов, больше среднего показателя({1}) = {2}", i, average[i], k);
                */
            Console.ReadLine();
            

            


        }
    }
}
