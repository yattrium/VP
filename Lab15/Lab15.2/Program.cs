using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15._2
{
    class Program
    {
        /*Дан массив A размера N. 
         * Сформировать новый массив B того же размера по следующему правилу: 
         * элемент BK равен среднему арифметическому элементов массива A с номерами от 1 до K. */
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];
            Random rand = new Random();

            Console.WriteLine("введите K");
            int K = Convert.ToInt32(Console.ReadLine());

            for (int k=0;k<N;k++)
            {
                A[k] = rand.Next(1, 20);
                B[k] = rand.Next(1, 20);
            }

            for (int i = 0, sum = 0; i < K; i++)
            {
                B[i] = (sum += A[i]) / (i + 1);
            }

            Console.WriteLine("массив A   "+ "массив В");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]+"   "+ B[i]);
            }

            Console.ReadLine();

        }
    }
}
