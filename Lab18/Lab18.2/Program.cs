using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._2
{
    class Program
    {   /*Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). 
        Найти сумму и произведение элементов K-й строки данной матрицы.*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите М");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите N");
            int N = Convert.ToInt32(Console.ReadLine());
            int i, K, j, sum = 0, pr = 1;
            int[,] arr = new int[M, N];
            Console.WriteLine("введите элементы матрицы ");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.WriteLine("A[{0},{1} ] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("введите К ");
            K = Convert.ToInt32(Console.ReadLine());
            K--;
            for (j = 0; j < N; j++)
            {
                sum =sum+ arr[K ,j];
                pr = pr*arr[K ,j];
            }

            Console.WriteLine("сумма элементов строки{0} равна {1}, произведение равно {2}", K+1, sum, pr);

            Console.ReadLine();
        }
    }
}
