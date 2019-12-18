using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19._5
{
    class Program
    {   /*Дана квадратная матрица A порядка M. 
        Найти сумму элементов каждой ее диагонали, параллельной главной (начиная с одноэлементной диагонали).*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[M,M];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int k;
            for (int i = M - 1; i > 0; i--)
            {
                k = 0;
                for (int j = 0; j < i; j++)
                {
                    k += arr[M - (i - j), j];
                }
                Console.WriteLine(k);
            }

            for (int i = 1; i < M; i++)
            {
                k = 0;
                for (int j = 0; j < i; j++)
                {
                    k += arr[j, M - (i - j)];
                }
                Console.WriteLine(k);
            }

            Console.ReadLine();

        }
    }
}
