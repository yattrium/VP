using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15._5
{
    class Program
    {   /*Дан массив размера N, все элементы которого, кроме первого, упорядочены по возрастанию. 
        Сделать массив упорядоченным, переместив первый элемент на новую позицию */

        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N];
            for(int i=0;i<N;i++)
            {
                Console.WriteLine("введите " + i + "элемент массива");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < N - 1; i++)
            {
                if (A[i] > A[i + 1])
                {
                    int temp = A[i];
                    A[i] = A[i + 1];
                    A[i + 1] = temp;
                }
                else
                    break;
            }
            Console.WriteLine("измененный массив");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }

            Console.ReadLine();



        }
    }
}
