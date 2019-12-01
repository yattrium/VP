using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._4
{
    class Program
    {
        /*Дан массив A размера N. Вывести его элементы в следующем порядке: A1, AN , A2, AN−1, A3, AN−2,*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N];


            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("введите " + i + " элемент массива");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {

                 Console.Write(A[i] + " " + A[N - i - 1] + " ");

            }
            Console.ReadLine();
        }
    }
}
