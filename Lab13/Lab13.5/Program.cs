using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._5
{
    class Program
    {
        /*5. Дан массив A размера N. Вывести вначале его элементы с нечетными номерами в порядке возрастания номеров, 
         * а затем — элементы с четными номерами в порядке убывания номеров*/
        static void Main(string[] args)
        {

            Console.WriteLine("введите размер массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N];

            for (int k = 0; k < N; k++)
            {
                Console.WriteLine("введите " + k + " элемент массива");
                A[k] = Convert.ToInt32(Console.ReadLine());
            }

            int i = 1;

            while (i < N)
            {
                Console.Write(A[i]);
                i += 2;
            }

            i = ((N-1) / 2) * 2;
            while (i >= 0)
            {              
                Console.Write(A[i]);
                i -= 2;
            }
            Console.ReadLine();
        }
    }
}
