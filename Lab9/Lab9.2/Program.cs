using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            char D;
            Console.WriteLine("введите направление: W-восток, E-запад, N-север, S-юг");
            D = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("введите команду: -1, 0, 1");
            A = Convert.ToInt32(Console.ReadLine());
            switch (A)
            {
                case -1:
                    switch (D)
                    {
                        case 'W': D = 'S'; break;
                        case 'E': D = 'N'; break;
                        case 'S': D = 'E'; break;
                        case 'N': D = 'W'; break;
                    }
                    Console.WriteLine(D);
                    break;

                case 1:
                    switch (D)
                    {
                        case 'W': D = 'N'; break;
                        case 'E': D = 'S'; break;
                        case 'S': D = 'W'; break;
                        case 'N': D = 'E'; break;
                    }
                    Console.WriteLine(D);
                    break;
                case 0:
                    Console.WriteLine(D);
                    break;

                default:
                    Console.WriteLine("неправильная команда");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
