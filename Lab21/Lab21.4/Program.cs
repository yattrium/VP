using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21._4
{
    class Program
    {   /*Дана строка-предложение на русском языке. 
        Подсчитать количество содержащихся в строке гласных букв.*/
        static void Main(string[] args)
        {
            char[] vowels = { 'А', 'а', 'Е', 'е', 'Ё', 'ё', 'И', 'и', 'О', 'о', 'У', 'у', 'ы', 'Э', 'э', 'Ю', 'ю', 'Я', 'я' };
            Console.Write("введите строку ");
            string s = Convert.ToString(Console.ReadLine());
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (s[i] == vowels[j])
                    {
                        k++;
                    }
                }
            }
            Console.WriteLine(k);
            Console.ReadLine();


        }
    }
}
