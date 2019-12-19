using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab22._4
{
    class Program
    {   /*Дан текстовый файл. Заменить в нем все подряд идущие пробелы на один пробел.*/
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nastya\Desktop\Лабы\Программирование\Lab22\text4.txt";
            string text = File.ReadAllText(path);
           
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            File.AppendAllText(path, text);

            string text1 = File.ReadAllText(path);
            Console.Write(text1);
            Console.ReadLine();

        }
    }
}
