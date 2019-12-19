using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21._6
{
    class Program
    {   /* Дана строка, содержащая полное имя файла. 
        Выделить из этой строки название последнего каталога (без символов «\»). 
        Если файл содержится в корневом каталоге, то вывести символ «\».*/
        static void Main(string[] args)
        {
            Console.Write("введите полный путь к файлу ");
            string File = Convert.ToString(Console.ReadLine());
            if ((char)(File.Split('\\').Length) > 2)
            {
               Console.WriteLine(File.Split('\\')[File.Split('\\').Length - 2]);
            }
            else Console.WriteLine("\\ ");
            Console.ReadLine();



            /*int s1, s2=0;
            Console.WriteLine("введите полный путь к файлу ");
           string File = Convert.ToString(Console.ReadLine());
            for (int i = 1; i < File.Length; i++)
                if (File[i] == '/')
                { 
                  s1= s2;
                  s2= i;
                }

            if (s2 == 0) { Console.WriteLine("\\"); }
             */
        }
    }
}
