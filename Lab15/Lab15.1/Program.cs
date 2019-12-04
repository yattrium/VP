using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15._1
{
    class Program
    {
        /*Даны массивы A и B одинакового размера N. 
         * Поменять местами их содержимое и вывести вначале элементы преобразованного массива A,
         * а затем — элементы преобразованного массива B.*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];
            Random rand = new Random();
            Console.WriteLine("неизмененные массивы");
            Console.WriteLine("A   B");
            for (int k=0;k<N;k++)
            {
                A[k] = rand.Next(1,100);
                B[k] = rand.Next(1,100);
                Console.WriteLine(A[k] + "   " + B[k]);
            }
            int v=0;
            Console.WriteLine("преобразованные массивы");
            Console.WriteLine("A   B");
            for (int i = 0; i < N; i++)
            {
                v = A[i];
                A[i] = B[i];
                B[i] = v;
                Console.WriteLine(A[i] + "   " + B[i]);             
            }

            Console.ReadLine();
        }
    }
}
