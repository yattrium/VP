using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21._5
{
    class Program
    {   /* Дана строка, содержащая полное имя файла, то есть имя диска, список каталогов (путь), 
        собственно имя и расширение. 
        Выделить из этой строки имя файла (без расширения)*/
        static void Main(string[] args)
        {
          
            Console.WriteLine("введите полный путь к файлу ");
            string File = Convert.ToString(Console.ReadLine());
            Console.Write(System.IO.Path.GetFileNameWithoutExtension(File)) ;
            Console.ReadLine();
        }
    }
}
