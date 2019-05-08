using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, Suma, Roznica, Iloczyn;
            Console.WriteLine("Podaj pierwszą liczbę rzeczywistą");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę rzeczywsitą");
            B = double.Parse(Console.ReadLine());
            Suma = A + B;
            Roznica = A - B;
            Iloczyn = A * B;
            Console.WriteLine("Suma tych liczb wynosi: {0,-2:F2}, Różnica: {1,-2:F2}, Iloczyn: {2,-2:F2}", Suma, Roznica, Iloczyn);
            Console.ReadKey();
        }
    }
}
