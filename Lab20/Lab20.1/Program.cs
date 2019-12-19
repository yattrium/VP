using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20._1
{
    class Program
    { /*Дан символ C. Вывести два символа, первый из которых
        предшествует символу C в кодовой таблице, а второй следует за символом C*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите символ С");
            char C = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("предыдущий символ = {0}, следующий символ = {1}", (char)(C - 1), (char)(C + 1));
            Console.ReadLine();

        }
    }
}
