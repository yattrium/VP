using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab22._3
{
    class Program
    {   /*Даны два текстовых файла. Добавить в начало первого файла содержимое второго файла*/
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\Nastya\Desktop\Лабы\Программирование\Lab22\text3-1.txt";
            string path2 = @"C:\Users\Nastya\Desktop\Лабы\Программирование\Lab22\text3-2.txt";
            string text = File.ReadAllText(path1);
            File.WriteAllText(path1, File.ReadAllText(path2) + text);

            string text1 = File.ReadAllText(path1);
            Console.Write(text1);
            Console.ReadLine();
        }
    }
}
