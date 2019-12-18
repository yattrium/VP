using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19._1
{
    class Program
    {   /* Дана матрица размера M × N. 
        Преобразовать матрицу, поменяв местами минимальный и максимальный элемент в каждой строке.*/
        static void Main(string[] args)
        {
            
            Console.Write("Введите N: ");
           int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите M: ");
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
            int min = int.MaxValue;
            int max = int.MinValue;
            int maxi = 0, maxj = 0, mini = 0, minj = 0, k;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        mini = i;
                        minj = j;
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxi = i;
                        maxj = j;
                    }
                }
                k = arr[maxi, maxj];
                arr[maxi, maxj] = arr[mini, minj];
                arr[mini, minj] = k;
                min = int.MaxValue;
                max = int.MinValue;
            }


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine("a[{0}, {1}] = {2}",i,j, arr[i, j]);
                }
            }
            Console.ReadLine();

        


        }
    }
}
