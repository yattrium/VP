using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._5
{
    class Program
    {
        /* Описать функцию Fact2(N) вещественного типа, вычисляющую двойной факториал: 
        N!! = 1·3·5·. . .·N, если N — нечетное; 
        N!! = 2·4·6·. . .·N, если N — четное 
        (N > 0 — параметр целого типа; вещественное возвращаемое значение используется для того, 
        чтобы избежать целочисленного переполнения при больших значениях N). */

        static double Fact2(int N)
        {
                double result = 1;
                for (int i = N % 2 == 0 ? 2 : 1; i <= N; i += 2)
                {
                    result *= i;
                }
                return result;
            }
        
        static void Main(string[] args)
        {

        }
    }
}
