using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz pierwsza liczbe calkowita");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz druga liczbe calkowita wieksza od liczby pierwszej");
            double y = double.Parse(Console.ReadLine());
            if (x % 2 == 1)
                x++;
            else
                x = x + 2;
            if (y % 2 == 1)
                y--;
            else
                y = y - 2;
                while (y >= x)
                {
                    Console.WriteLine(x);
                    x++;
                    x++;
                }
            Console.ReadKey();
        }
    }
}
