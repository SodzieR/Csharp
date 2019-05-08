using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[] { 19, 34, 23, 54, 31 };
            int[] odwrotnie = new int[liczby.Length];
            int i = 4;
            foreach (int liczba in liczby)
            {
                int[] odwrot = new int[liczby.Length];
                Console.WriteLine(odwrot);
            }
            Console.ReadKey();
        }
    }
}
