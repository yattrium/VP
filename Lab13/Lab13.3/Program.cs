using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._3
{
    class Program
    {
        /*Даны целые числа N (> 2), A и B. Сформировать и вывести целочисленный массив размера N, 
         * первый элемент которого равен A, второй равен B, а каждый последующий элемент равен сумме всех предыдущих*/

        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[N];

            Console.WriteLine("введите первый элемент A");
            int A = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("введите второй элемент В");
            int B = Convert.ToInt32(Console.ReadLine());

            Arr[0] = A;
            Arr[1] = B;

            for (int i = 2; i < N; i++)
            {
                Arr[i] = Arr[i - 2] +Arr[i-1] ;
                Console.Write(Arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
