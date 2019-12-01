using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Начальный вклад в банке равен 1000 руб. 
             * Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы (
             * P — вещественное число, 0 < P < 25). По данному P определить, через сколько месяцев размер 
             * вклада превысит 1100 руб., и вывести найденное количество месяцев K (целое число) и итоговый 
             * размер вклада S (вещественное число). */

            int B = 1000;
            double P, K, S;
            Console.WriteLine("введите процент P");
            P = Convert.ToDouble(Console.ReadLine());
            K = 0;
            S = B;
            for (int i = 1; S <= 1100; i++)
            {
                S = S + ((S * P) / 100);
                K++;
            } 
            Console.WriteLine("количество месяцев "+ K +" итоговый размер вклада "+ S); 

            Console.ReadLine();
        }
    }
}
