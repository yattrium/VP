using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21._1
{
    class Program
    {   /*1. Дана строка, состоящая из русских слов,
        разделенных пробелами (одним или несколькими). Найти количество слов в строке.*/
        static void Main(string[] args)
        {
            Console.Write("Введите строку S ");
            string S = Convert.ToString(Console.ReadLine());
            int k = 1;
            for (int i = 0; i < S.Length; i++)
            {
                if ((S[i] == ' ') && (S[i - 1] != ' '))
                {
                    k++;
                }
            }
            Console.Write(k);
            Console.ReadLine();
        }
    }
}
