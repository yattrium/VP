using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._3
{
    class Program
    {   /*Дана матрица размера M × N. Найти номер ее столбца с наименьшим произведением элементов 
       и вывести данный номер, а также значение наименьшего произведения.*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите N");
            int N = Convert.ToInt32(Console.ReadLine()); //столбцы
            Console.WriteLine("введите M");
             int M = Convert.ToInt32(Console.ReadLine()); //строки
             
             int min = int.MinValue,p = 1,ind=0;
             int[,] arr = new int[M, N];
             Console.WriteLine("введите элементы матрицы ");
             for (int i = 0; i < N; i++)
             {
                 for (int j = 0; j < M; j++)
                 {
                     Console.WriteLine("A[{0},{1} ] = ", i, j);
                     arr[i, j] = Convert.ToInt32(Console.ReadLine());
                 }
             }
            for (int i = 0; i < N; i++)
            {
                p = 1;
                for (int j = 0; j < M; j++)
                {
                    p *= arr[j, i];
                }
                if (p < min)
                {
                    min = p;
                    ind = i;
                }
            }
            Console.WriteLine("номер столбца с наименьшим произведением элементов = {0}, наименьшее произведение = {1}", ind, min);
             Console.ReadLine();
        }
    }
}
