using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 10;
            double x = 12.345678, y = 24.56, wskaznik = 0.45;
            string imie = "Ala", naz = "Nowak";
            Console.WriteLine("1. Imię: {0,15} Nazwisko: {1,20}", imie, naz);
            Console.WriteLine("2. Imię: {0, -15} Nazwisko: {1, -20}", imie, naz);
            Console.WriteLine("3. Wartość {0, 10} to suma", suma);
            Console.WriteLine("4. Wartość {0, -10} to suma", suma);
            Console.WriteLine("5. Wskaźnik: {0,8:P}", wskaznik);
            Console.WriteLine("6. Waga: {0,10} kg", x);
            Console.WriteLine("7, {0, -10:F4} (4cyfry po przecinku)", x);
            Console.WriteLine("8. Wartość x={0, -10:F4} y={1,-10:F2}", x, y);
            Console.WriteLine("9. A ta liczba będzie w klamrach {{{0}}}", y);
            Console.ReadKey();
        }
    }
}
