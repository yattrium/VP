using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20._4
{
    class Program
    { /*Дан символ C и строка S. Удвоить каждое вхождение символа C в строку S*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку S ");
            char[] S = (Console.ReadLine().ToCharArray());
            Console.WriteLine("введите символ C ");
            char C = Convert.ToChar(Console.ReadLine());
            
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                {
                    int size = S.Length + 1;
                    Array.Resize(ref S, size);
                    for (int j = S.Length - 2; j >= i; j--)
                    {
                        S[j + 1] = S[j];
                    }
                    i++;

                }
            }
            string result = new string(S);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
