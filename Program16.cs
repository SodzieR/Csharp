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
            int n = 10;
            Random rand = new Random();
            int[,] tablica = new int[n, n];
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    tablica[j, i] = rand.Next(1, 100); 
                    Console.Write("{0,3}, ", tablica[j, i]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
