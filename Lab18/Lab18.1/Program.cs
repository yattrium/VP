using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._1
{
    class Program
    {   /*Дана квадратная матрица A порядка M (M — нечетное число). 
        Начиная с элемента A1,1 и перемещаясь против часовой стрелки, 
        вывести все ее элементы по спирали: первый столбец, последняя строка, 
        последний столбец в обратном порядке,первая строка в обратном порядке, 
        оставшиеся элементы второго столбца и т. д.; последним выводится центральный элемент матрицы.*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите М(нечетное число)");
            int M = Convert.ToInt32(Console.ReadLine());
            int i, k, j;
            int[,] A = new int[M, M];
            Console.WriteLine("введите элементы массива ");
            for ( i = 0; i < M; i++)
            {
                for ( j = 0; j < M; j++)
                {
                    Console.WriteLine( "A[{0},{1} ] = ",i,j);
                     A[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            
            for (k = 0; k < (M / 2 + 1); k++)
            {
                for (i = k; i < M - k; i++)
                {
                    Console.WriteLine(A[i,k]);
                }
                i--;
                for (j = k + 1; j < M - k; j++)
                {
                    Console.WriteLine(A[i, j]);
                }
                j--;
                for (i = M - k - 2; i >= k; i--)
                {
                    Console.WriteLine(A[i, j]);
                }
                i++;
                for (j = M - k - 2; j > k; j--)
                {
                    Console.WriteLine(A[i, j]);
                }
                j++;
            }

            Console.ReadLine();

        }
    }
}
