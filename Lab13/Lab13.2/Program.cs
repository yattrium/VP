using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._2
{
    class Program
    {   /*Дано целое число N (> 1), а также первый член A и знаменатель D геометрической прогрессии. 
        Сформировать и вывести массив размера N, содержащий N первых членов данной 
        прогрессии: A, A·D, A·D2 , A·D3 , . . . */
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[N];

            Console.WriteLine("введите знаменатель геометрической прогрессии");
            int D = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите первый элемент геометрической прогрессии");
            int A = Convert.ToInt32(Console.ReadLine());

            Arr[0]=A;

            for (int i = 1; i < N; i++)
            {
                Arr[i] = Arr[i - 1] *D;
                    Console.Write(Arr[i] + " ");                   
            }

            Console.ReadLine();
        }
    }
}
