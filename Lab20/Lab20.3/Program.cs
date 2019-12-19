using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20._3
{
    class Program
    {   /*Дана строка. Подсчитать количество содержащихся в ней прописных латинских букв*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string S = Convert.ToString(Console.ReadLine());
            int k = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if ((char)S[i] >= 'A' && (char)S[i] <= 'Z' || (char)S[i] >= 'A' && (char)S[i] <= 'Z')
                {
                    k++;
                }
            }
            Console.WriteLine("количество прописных латинских букв "+k);
            Console.ReadLine();
        }
    }
}
