using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz swoj tekst");
            string txt = Console.ReadLine();
            char[] unwanted_charc = { ' ', ',', '.','\'', '*','-', '/'};
            string txt_cleaned = txt.TrimStart(unwanted_charc);
            Console.Write(txt_cleaned);
            Console.ReadKey();
        }
    }
}
