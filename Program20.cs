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
            Console.WriteLine("Wpisz swoj tekst, wyrazy oddziel spacja");
            string txt = Console.ReadLine();
            char[] separatory = { ' ', ',', '.', '-', ';'};
            string[] txt_table = txt.Split(separatory);
            string longest_word = "";
            int i = 0;
            foreach (string following_word_from_txtTable in txt_table)
            {
                if (following_word_from_txtTable.Length > i)
                {
                    longest_word = following_word_from_txtTable;
                    i = following_word_from_txtTable.Length;
                }
            }
            Console.WriteLine(longest_word);
            Console.ReadKey();
        }
    }
}
