using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21._7
{
    class Program
    {   /*Дана строка-предложение. Зашифровать ее, поместив вначале все символы,
        расположенные на четных позициях строки, а затем, в обратном, все символы,
        расположенные на нечетных позициях (например, строка «Программа» превратится в «ргамамроП»).*/
        static void Main(string[] args)
        {
            Console.Write("введите предложение ");
            string S = Convert.ToString(Console.ReadLine());
            char[] s1 = S.ToCharArray();
           
           int a=0,b = S.Length;
            for (int i = 0; i < b; i++)
            {
                if (i % 2 == 1)
                {
                    s1[i / 2] = S[i];
                }
            }
            for (int i = b - 1; i >= b / 2; i--)
            {
                s1[i] = S[a];
                a += 2;
            }
            Console.WriteLine(s1);

            Console.ReadLine();




        }
    }
}
