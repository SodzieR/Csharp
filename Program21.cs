using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz swoj tekst.");
            string txt = Console.ReadLine();
            Console.WriteLine("Ktorego wyrazu wystepowanie chcesz sprawdzic? (Wpisz go zwazajac na duze i male, i polskie litery");
            string chosen_word = Console.ReadLine();
            int i = 0;
            if (txt.Contains(chosen_word)) //wystepuje
            {
                i = 2;
                if (txt.StartsWith(chosen_word)) // wystepuje jako prefiks
                    i = 3;
                if (txt.EndsWith(chosen_word)) // wystepuje jako sufiks
                    i = 4;
                if (txt.EndsWith(chosen_word) & txt.StartsWith(chosen_word)) // wystepuje jako prefiks i sufiks
                    i = 5;
            }
            else i = 1;
            switch (i)
            {
                case 1:
                    Console.WriteLine("Nie występuje");
                    break;
                case 2:
                    Console.WriteLine("Występuje");
                    break;
                case 3:
                    Console.WriteLine("Występuje jako prefiks");
                    break;
                case 4:
                    Console.WriteLine("Występuje jako sufiks");
                    break;
                case 5:
                    Console.WriteLine("Występuje jako prefiks i sufiks");
                    break;
            }
            Console.ReadKey();
        }
    }
}
