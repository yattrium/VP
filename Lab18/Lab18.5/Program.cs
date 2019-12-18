using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._5
{
    class Program
    {   /*Дана целочисленная матрица размера M × N. Найти номер первого из ее столбцов, 
        содержащих только нечетные числа. Если таких столбцов нет, то вывести 0.*/
        static void Main(string[] args)
        {
            int N, M;
            Console.Write("Введите M: ");
            M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите N: ");
            N = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("A[{0},{1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int k = 0;
            bool ind = false;
            for (int i = 0; i < M; i++)
            {
                ind = true;
                for (int j = 0; j < N; j++)
                {
                    if (arr[j, i] % 2 == 0)
                    {
                        ind = false;
                    }

                }
                if (ind)
                {
                    k = i;
                    Console.WriteLine("Номер первого столбца со всеми нечетными числами= "+ k);                   
                    Console.ReadLine();
                    break;
                }
            }

            Console.Write(k);
            Console.ReadLine();



        }
    }
}
