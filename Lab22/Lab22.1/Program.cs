using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22._1
{
    class Program
    {   /*Дан символьный файл, содержащий по крайней мере один символ пробела.
        Удалить все его элементы, расположенные перед первым символом пробела, включая и этот пробел.*/
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nastya\Desktop\Лабы\Программирование\Lab22\text1.txt";
            string text = System.IO.File.ReadAllText(path);
            text = text.Remove(0, text.IndexOf(' ') + 1);
            System.IO.File.WriteAllText(path, text);
            Console.WriteLine(text);
            Console.ReadLine();

        }
    }
}
