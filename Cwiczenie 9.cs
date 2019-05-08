using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj wartość pierwszej przyprostokątnej 'a'");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość drugiej przyprostokątnej 'b'");
            b = double.Parse(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Długość przeciwprostokątnej wynosi : {0,-10:F4}", c);
            Console.ReadKey();
        }
    }
}
