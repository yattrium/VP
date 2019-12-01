using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] color = new string[5] { "бело", "черно", "зелено", "красно", "желто" };
            string[] animal = new string[12] { "й крысы", "й коровы", "го тигра", "го зайца", "го дракона", "й змеи", "й лошади", "й овцы", "й обезьяны", "й курицы", "й собаки", "й свиньи" };
            Console.WriteLine("введите год");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("год ");
            Console.Write(color[(N%60) / 12] + animal[(N%60) % 12]);
            Console.ReadLine();
            

            

        }
    }
}
