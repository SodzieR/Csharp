using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[] { 19, 34, 23, 54, 31 };
            int[] odwrotnie = new int[liczby.Length];
            for (int i = 0; i < liczby.Length;)
            {
                Console.Write(liczby[i] + ",");
            }
            Console.ReadKey();
        }
    }
}
