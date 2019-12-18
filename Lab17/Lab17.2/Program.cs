using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17._2
{
    class Program
    {
        /*Дано целое число L (> 0) и целочисленный массив размера N. 
         * Заменить каждую серию массива, длина которой больше L, на один элемент с нулевым значением*/
        static void Main(string[] args)
        {

            int c;
            Console.WriteLine("введите длинну массива") ;
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            Console.WriteLine( "введите массив");
            for (int i = 0; i < N; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("введите длинну серии");
            int L = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                c = 1;
                for (int j = i + 1; j < N; j++)
                {
                    if (arr[j] == arr[i]) { c++; }
                    else { break; }
                }
                if (c > L)
                {
                    for (int j = i; j < i + c; j++)
                    {
                        Console.WriteLine(arr[j]); 
                    }
                    i = i + c;
                }
                if (c == L) { i = i + L - 1; Console.WriteLine( "0") ; }
                else { Console.WriteLine(arr[i] ); }
            }

            Console.ReadLine();

            /*  Console.WriteLine("введите L>0");
              int L = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("введите N - размер массива ");
              int N = Convert.ToInt32(Console.ReadLine());

              int[] arr = new int[N];
              int[] arr2 = new int[N];
              //если не равен предыдущему то записывается в массив иначе ноль
               for (int i=0;i<N;i++)
               {
                  Console.WriteLine("введите элемент " + i);
                  arr[i] = Convert.ToInt32(Console.ReadLine());
               }
              arr2[0] = arr[0];
              for (int i=0;i<N;i++)
              for (int i = 1; i < N; i++)
              {
                  if (arr[i]!=arr[i-1]) { arr2[i] = arr[i]; }
                  else { arr2[i] = 0; }
              }

              for (int i=0;i<N;i++)
              {
                  Console.WriteLine(arr2[i]);
              }
              Console.ReadLine();

                  */



        }
    }
}
