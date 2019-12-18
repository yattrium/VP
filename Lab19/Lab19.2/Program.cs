using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19._2
{
    class Program
    {       /*Дана матрица размера M × N. 
            Поменять местами столбцы, содержащие минимальный и максимальный элементы матрицы.*/
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
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxj = 0, minj = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxj = j;
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minj = j;
                    }
                }
            }
            int k;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    k = arr[i, minj];
                    arr[i, minj] = arr[i, maxj];
                    arr[i, maxj] = k;
                }
            }

            for (int i = 0; i < N; i++)
            {           
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }
            Console.ReadLine();

        }
    }
}
