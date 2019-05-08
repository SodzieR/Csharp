using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile elementów tablicy chcesz wpisać?");
            int ilosc_elementow = int.Parse(Console.ReadLine());
            int[] elementy = new int[ilosc_elementow];
            int i = 0;
            while (i < ilosc_elementow)
            {
                Console.WriteLine("Podaj {0} element.", i+1);
                elementy[i] = int.Parse(Console.ReadLine());
                i++;
            }
            double wynik = 0;
            for (int x = 0; x < ilosc_elementow; x++)
            {
                wynik = wynik + elementy[x];
            }
            double srednia = wynik / (double)ilosc_elementow;
            Console.WriteLine("Najwieksza wartosc tablicy elementow to: {0}, a index tego elementu w tablicy to {1}", elementy.Max(), Array.IndexOf(elementy, elementy.Max()));
            Console.WriteLine("Najmniejsza wartosc tablicy elementow to: {0}, a index tego elementu w tablicy to {1}", elementy.Min(), Array.IndexOf(elementy, elementy.Min()));
            Console.WriteLine("Srednia wartosc wszystkich elementow talbicy to: {0}", srednia);
            Console.ReadKey();
        }
    }
}
