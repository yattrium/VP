using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19._3
{
    class Program
    {   /*Дана матрица размера M × N (M и N — четные числа). 
        Поменять местами левую верхнюю и правую нижнюю четверти матрицы*/
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
            for (int i = 0; i < N / 2; i++)
            {
                for (int j = 0; j < M / 2; j++)
                {
                    k = arr[i, j];
                    arr[i, j] = arr[i + N / 2, j + M / 2];
                    arr[i + N / 2, j + M / 2] = k;
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
