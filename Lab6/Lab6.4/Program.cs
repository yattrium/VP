using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C,P,T;
            Console.WriteLine("введите А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите C");
            C = Convert.ToInt32(Console.ReadLine());
            P = (A / C) * (B / C); //количество квадвратов в прямоугольнике
            T = (A * B) - (P*C*C); //незанятая часть
            Console.WriteLine("количество квадратов в прямоугольнике" + P);
            Console.WriteLine("незанятая часть" + T);
            Console.ReadLine();




        }
    }
}
