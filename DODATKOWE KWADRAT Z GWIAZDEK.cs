using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            Console.WriteLine("Podaj długość boku kwadratu");
            int side_length = Int32.Parse(Console.ReadLine());
            char[,] rysunek = new char[side_length, side_length];
            for (int j = 0; j < side_length; j++)
            {
                for (int i = 0; i < side_length; i++)
                {
                    rysunek[j, i] = star;
                    Console.Write("{0}", rysunek[j, i]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
