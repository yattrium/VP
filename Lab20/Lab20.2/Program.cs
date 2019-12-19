using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20._2
{
    class Program
    {   /*Дана непустая строка S. Вывести строку, содержащую символы строки S, 
        между которыми вставлено по одному пробелу*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку S");
            string S = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < S.Length; i++)
            {
                Console.Write(S[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
