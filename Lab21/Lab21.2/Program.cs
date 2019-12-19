using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21._2
{
    class Program
    { /*Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими). 
        Найти длину самого короткого слова*/
        static void Main(string[] args)
        {
           Console.Write("введите слово ");
           string S = Convert.ToString(Console.ReadLine());
            int w=0,min=int.MaxValue;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] != ' ') { w++; }
                if (S[i] == ' ' || i == S.Length - 1)
                {
                    if (w!= 0 && w < min)
                    {
                        min = w;
                    }
                    w = 0;
                }
            }
            /*for (int i=1;i<S.Length;i++)
            {
                if (S[i]!=' ')
                {
                    w = w + 1;
                }
                else if (w<min&&w!=0)
                {
                    min = w;
                    w = 0;
                }
            }*/

            Console.WriteLine("длинна самого короткого слова равна "+min);
            Console.ReadLine();



        }
    }
}
