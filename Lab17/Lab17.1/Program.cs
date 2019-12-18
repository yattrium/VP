using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17._1
{
    class Program
    {   /*Дан целочисленный массив A размера N. 
        Назовем серией группу подряд идущих одинаковых элементов, 
        а длиной серии — количество этих элементов (длина серии может быть равна 1). 
        Сформировать два новых целочисленных массива B и C одинакового размера, 
        записав в массив B длины всех серий исходного массива, 
        а в массив C — значения элементов, образующих эти серии*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            int[] b = new int[N];
            int[] c = new int[N];

            Console.WriteLine("заполнение массива а");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("введите значение элемента" + i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int k = 0;
            c[k] = 1;
            b[k] = a[k];
            for (int i = 1; i < N; i++)
            {
                if (a[i - 1] == a[i])
                {
                    c[k]++;
                }
                else
                {
                    k++;
                    c[k] = 1;
                    b[k] = a[i];
                }
            }
            Console.WriteLine("массив В - массив С");
            for (int i = 0; i <= k; i++)
            {
                Console.WriteLine(b[i] + " - " + c[i]);

            }
            Console.ReadLine();
        }
    }
}
