using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._5
{
    class Program
    {
        /*Дан целочисленный массив размера N, содержащий ровно два одинаковых элемента. 
         * Найти номера одинаковых элементов и вывести эти номера в порядке возрастания */
        static void Main(string[] args)
        {
            int var=0, var2=0;
            Console.WriteLine("введите размер массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[N];
            for (int k = 0; k < N; k++)
            {
                Console.WriteLine("введите " + k + " элемент массива");
                Arr[k] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < (N - 1); i++)
            {        
                for (int j = 1; j < N; j++)
                {
                    if ((Arr[i] == Arr[j]) && (i != j))
                    {
                        var = i;
                        var2 = j;
                    }
                }
            }
            if (var<var2) 
            { Console.WriteLine("номера одинаковых элементов " + var + " " + var2); }
            else { Console.WriteLine("номера одинаковых элементов " + var2+ " " + var); }

            Console.ReadLine();
        }
    }
}
