using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój łancuch znaków w ciągu, bez przecinków, z małymi literami bez cyfr.");
            string znaki = Console.ReadLine();
            string s1 = "bcdfghjklmnprstwz";
            string s2 = "zwtsrpnmlkjhgfdcb";
            Console.Write("Twój zaszyfrowany tekst to: ");
            for (int i = 0; i < znaki.Length; i++)
            {
                char znak = znaki[i];
                int pozycja_s1 = s1.IndexOf(znaki[i]);
                if(pozycja_s1 < 0 )
                {
                }
                else
                {
                    znak = s2[pozycja_s1];
                }
                Console.Write(znak);
            }
            Console.ReadKey();
        }
    }
}
