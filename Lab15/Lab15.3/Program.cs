using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15._3
{
    class Program
    {
        /*Дан целочисленный массив размера N. Увеличить все нечетные числа, 
         * содержащиеся в массиве, на исходное значение последнего нечетного числа. 
         * Если нечетные числа в массиве отсутствуют, то оставить массив без изменений*/

        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N];
            Random rand = new Random();

            for (int k=0;k<N;k++)
            {
                A[k] = rand.Next(1, 100);
            }

            int l=0;

            for (int i=0;i<N;i++)
            {
                Console.WriteLine(A[i]);
            
                  if (A[i]%2==1)
                  {
                    A[i] +=l;
                    l = A[i];
                    Console.WriteLine("("+A[i]+")"); //измененное значение элемента
                  }
            }
            Console.ReadLine();
        }
        
    }
}
