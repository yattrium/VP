using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._4
{
    class Program
    {   /* Дано множество A из N точек (точки заданы своими координатами x, y). 
        Среди всех точек этого множества, лежащих во второй четверти, найти точку, 
        наиболее удаленную от начала координат. 
        Если таких точек нет, то вывести точку с нулевыми координатами*/
        static void Main(string[] args)

        {        
            Console.WriteLine("введите N ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[N];
            int[] y = new int[N];
            int indx=0, indy=0;
            double max = 0, j = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("введите х точки " + i);
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите у точки " + i);
                y[i] = Convert.ToInt32(Console.ReadLine());
                j = Math.Sqrt(x[i] * x[i] + y[i] * y[i]);
                if (x[i] < 0 && y[i] > 0 && j > max)
                {
                    max = j;
                    indx = x[i];
                    indy = y[i];
                }
               /* else
                {
                    Console.WriteLine("точка находится вне второй четверти");
                }    */          
            }
              if (max>0)
            {
                Console.WriteLine("наиболее отдаленная точка {0};{1}", indx, indy);
            }


            Console.ReadLine();


            /*int x, y,indx=0,indy=0;
            double H,max=0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("введите координату x точки " + i);
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите координату y точки " + i);
                y = Convert.ToInt32(Console.ReadLine());
                
                if (x < 0 && y > 0)
                {
                    H = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                    if (H > max)
                    {
                        max = H;
                        indx = x;
                        indy = y;
                        N = i;
                    }
                } 
                else
                {
                    Console.WriteLine("точка находится вне второй четверти");
                }
                if (max > 0)
                {
                    Console.WriteLine("наиболее удаленная точка" + indx + indy);
                }
                else
                {
                    Console.WriteLine("0,0");
                }
            }
           

            Console.ReadLine(); */

        }
    }
}
