using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica = new int[10, 10] { {Random, Random, Random, Random, Random, },
                { Random, Random, Random, Random, Random, },
                { Random, Random, Random, Random, Random, },
                {Random, Random, Random, Random, Random, },
                {Random, Random, Random, Random, Random, } };
            int suma = 0;
            for (int j = 0; j < tablica.GetLength(1); j++)
            {
                for (int i = 0; i < tablica.GetLength(0); i++)
                {
                    Console.Write("{0} ", tablica[j, i]);
                }
                Console.WriteLine();
            }
            for (int j = 0; j < tablica.GetLength(1); j++)
            {
                suma = suma + (tablica[j, j]);
            }
            Console.WriteLine("Suma po przekątnej: {0}", suma);
            Console.Read();
        }
    }
}
