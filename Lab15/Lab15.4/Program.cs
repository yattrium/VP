using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15._4
{
    class Program
    {
        /*Дан массив размера N. Обнулить элементы массива, 
         * расположенные между его минимальным и максимальным элементами 
         * (не включая минимальный и максимальный элементы).*/

        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N];
            Random rand = new Random();

            Console.WriteLine("изначальный массив");
            for (int k = 0; k < N; k++)
            {
                A[k] = rand.Next(1, 100);
                Console.WriteLine(A[k]);
            }

            int min = A[0], max = A[0];
            int indn = 0, indx = 0;

            for (int i = 1; i < N; i++)
            {
                if (A[i] > max) { max = A[i]; indx = i; }
                if (A[i] < min) { min = A[i]; indn = i; }
            }
            Console.WriteLine("изменненый массив");

            if (indx > indn)
            {
                for (int i = indn+1; i < indx; i++)
                {
                    A[i] = 0;
                }
            }
            else if (indx < indn)
            {
                for (int i = indx+1; i < indn; i++)
                {
                    A[i] = 0;
                }
            }

            for ( int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.ReadLine();
        }
    }
        
 }
