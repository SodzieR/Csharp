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
            Console.WriteLine("Wpisz swój lancuch znakow");
            string zdanie = Console.ReadLine();
            int space_count = zdanie.Count(Char.IsWhiteSpace);
            Console.WriteLine("Ilość wyrazów w zdaniu: {0}", space_count+1);
            Console.ReadKey();
        }
    }
}