using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._4
{
    class Program
    {
        /*4. Описать функцию Quarter(x, y) целого типа, определяющую номер координатной четверти, 
         * в которой находится точка с ненулевыми вещественными координатами (x, y). 
         * С помощью этой функции найти номера координатных четвертей для трех точек с данными ненулевыми координатами*/
       static int Quarter(int x, int y)
        {
            int quarter = 0;

            if (x > 0)
            {
                if (y > 0)
                    quarter = 1;
                else if (y < 0)
                    quarter = 2;
            }
            else
            {
                if (y > 0)
                    quarter = 4;
                else if (y < 0)
                    quarter = 3;
            }

            return quarter;
        }



        static void Main(string[] args)
        {
            int x, y;
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("точка номер " + i);
                Console.WriteLine("введите ненулевую координату х");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите ненулевую координату у");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("номер координатной четверти " + i + " равен " + Quarter(x,y));
            }
            Console.ReadLine();
        }
    }
}
