using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._3
{
    class Program
    {
        /*Описать функцию RingS(R1, R2) вещественного типа, находящую площадь кольца, 
         * заключенного между двумя окружностями с общим центром и радиусами R1 и R2 (R1 и R2 — вещественные, R1 > R2).
         * С ее помощью найти площади трех колец, для которых даны внешние и внутренние радиусы.*/

        static double RingS(double R1,double R2)
        {
            return 3.14 * (Math.Sqrt(R1) - Math.Sqrt(R2));
        }
        static void Main(string[] args)
        {
            int R1, R2;
            for (int x=1;x<4;x++)
            {
                Console.WriteLine("кольцо номер " + x);
                Console.WriteLine("введите внешний радиус R1");
                R1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите внутренний радиус R2");
                R2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("площадь кольца " + x + " равна " + RingS(R1,R2));
            }
            Console.ReadLine();
        }
    }
}
