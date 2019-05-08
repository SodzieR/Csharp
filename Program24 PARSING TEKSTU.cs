using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            double mean = 0;
            Console.WriteLine("Wpisz tekst zawierajacy liczby oddzielone przecinakmi");
            string numbers = Console.ReadLine();
            numbers = numbers.Trim(' ');
            string[] numbers_table = numbers.Split(',');
            int[] liczby = new int[numbers_table.Length];
            for (int i = 0; i < numbers_table.Length; i++)
            {
                liczby[i] = Convert.ToInt32(numbers_table[i]);
                suma = liczby[i] + suma;
            }
            mean = suma / numbers_table.Length;
            Console.Write(mean);
            Console.ReadKey();
        }
    }
}
