using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab22._2
{
    class Program
    {   /*Дано имя файла и целые положительные числа N и K. 
        Создать текстовый файл с указанным именем и записать в него N строк,
        каждая из которых состоит из K символов «*» (звездочка)*/
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nastya\Desktop\Лабы\Программирование\Lab22\text2.txt";
            string text = File.ReadAllText(path);
            Console.Write("Введите число K(кол-во звезд): ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число N(строки): ");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    File.AppendAllText(path, string.Join(path, " * "));
                }
                File.AppendAllText(path, Environment.NewLine);
            }
            string text1 = File.ReadAllText(path);
            Console.Write(text1);
            Console.ReadLine();
        }
    }
}
