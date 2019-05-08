using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz swoj tekst");
            string txt = Console.ReadLine();
            Console.WriteLine("Wpisz swoj wyraz ktorego polozenie chcesz poznac");
            string chosen_word = Console.ReadLine();
            int a = 0;
            int position;
            if (txt.Contains(chosen_word))
            {
                position = txt.IndexOf(chosen_word);
                Console.WriteLine("Wybrany wyraz wystapil na {0} pozycji w Twoim tekscie", position);
                do
                {
                    position = txt.IndexOf(chosen_word, a);
                    a = position + chosen_word.Length;
                    if (position >= 0)
                        Console.Write("{0}, ", position + 1);
                } while (position >= 0);
            }
            else Console.WriteLine("Nie wystepuje");
            Console.ReadKey();
        }
    }
}
