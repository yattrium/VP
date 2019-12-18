using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17._3
{
    class Program
    {   /*Дано целое число K (> 0) и целочисленный массив размера N. 
        Поменять местами последнюю серию массива и его серию с номером K */
        static void Main(string[] args)
        {
            Console.WriteLine("введите длинну массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            int[] arr2 = new int[N];
            Console.WriteLine("введите массив");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("введите элемент " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("введите число К");
            int K = Convert.ToInt32(Console.ReadLine());

            int num = 0, indn = 0, indk = 0, size = 0;
            K--;
            for (int i = 1; i < N; i++)
            {
                if (arr[i - 1] != arr[i])
                {
                    num++;
                    if (num == K)
                    {
                        indn = i; 
                    }
                    indk = i; 
                }
                if (num == K)
                {
                    size++;
                }
            }

            int c = -1;

            for (int i = 0; i < indn; i++)
            {
                c++;
                arr2[c] = arr[i];
            }
            for (int i = indk; i < N; i++)
            {
                c++;
                arr2[c] = arr[i];
            }
            for (int i = indn + size; i < indk; i++)
            {
                c++;
                arr2[c] = arr[i];
            }
            for (int i = indn; i < indn + size; i++)
            {
                c++;
                arr2[c] = arr[i];
            }


            for (int i = 0; i < N; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.ReadLine();

        }
    }
}
