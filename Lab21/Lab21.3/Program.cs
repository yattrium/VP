using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21._3
{
    class Program
    {   /*Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами 
        (одним или несколькими). Преобразовать каждое слово в строке,
        заменив в нем все последующие вхождения его первой буквы на символ «.» (точка). 
        Например, слово «МИНИМУМ» надо преобразовать в «МИНИ.У.». Количество пробелов между словами не изменять*/
        static void Main(string[] args)
        {
            Console.Write("введите слово ");
            string S = Convert.ToString(Console.ReadLine());
            char[] chS =  S.ToCharArray();
            char c = chS[0];
            for (int i = 1; i < S.Length; i++)
            {
                if (chS[i] == c)
                {
                    chS[i] = '.';
                }
                if (chS[i] == ' ' && chS[i + 1] != ' ')
                {
                    c = chS[i + 1];
                    i++;
                }
            }
            S = new string(chS);

            Console.WriteLine(S);
            Console.ReadLine();




        }
    }
}
