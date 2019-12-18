using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17._5
{
    class Program
    {   /*Дано множество A из N точек (N > 2, точки заданы своими координатами x, y).
        Найти наибольший периметр треугольника, вершины которого принадлежат различным точкам множества A, 
        и сами эти точки (точки выводятся в том же порядке, в котором они перечислены при задании множества A).*/
        static void Main(string[] args)
        {
            
            double a = 0, b = 0, c = 0,p=0, maxp = 0, maxx1, maxy1, maxx2, maxy2, maxx3, maxy3;
            Console.WriteLine("введите N ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[N];
            int[] y = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("введите х точки " + i);
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите у точки " + i);
                y[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < N - 2; i++)
            {
                for (int j = i + 1; j < N - 1; j++)
                {
                    for (int k = i + 2; k < N; k++)
                    {
                        a = Math.Sqrt(Math.Pow(x[i] - x[j], 2) + Math.Pow(y[i] - y[j], 2));
                        b = Math.Sqrt(Math.Pow(x[i] - x[k], 2) + Math.Pow(y[i] - y[k], 2));
                        c = Math.Sqrt(Math.Pow(x[j] - x[k], 2) + Math.Pow(y[j] - y[k], 2));

                        p = a + b + c;

                        if (a < (b + c) & b < (a + c) & c < (a + b) & (p > maxp))
                        {
                            maxp = p;
                            maxx1 = x[i];
                            maxy1 = y[i];
                            maxx2 = x[j];
                            maxy2 = y[j];
                            maxx3 = x[k];
                            maxy3 = y[k];
                        }
                    }
                }
            }
            Console.WriteLine("периметр наибольшего возможного треугольника " + maxp);
            Console.ReadLine();

        }
    }
}
