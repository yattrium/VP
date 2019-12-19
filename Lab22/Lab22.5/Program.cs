using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab22._5
{
    class Program
    {  /*Дан текстовый файл. Найти количество абзацев в тексте, 
        если первая строка каждого абзаца начинается с 5 пробелов(«красная строка»).
        Пустые строки между абзацами не учитывать*/
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nastya\Desktop\Лабы\Программирование\Lab22\text5.txt";
            string text = File.ReadAllText(path);
            string pattern = @"     ";
            int k = 0;
            Regex space = new Regex(pattern);
            MatchCollection matches = space.Matches(text);
            foreach (Match mat in matches)
            {
                k++;
            }
            Console.Write(k);
            Console.ReadLine();
        }
    }
}
