using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1
{
    class Program
    {
        struct Samochod
        {
            public double cena;
            public double rocznik;
            public double przebieg;
            public string marka;
        }
        static double Wczytaj_cene()
        {
            double cena;
            do
            {
                cena = double.Parse(Console.ReadLine());
                if (cena < 0)
                    Console.WriteLine("Cena nie moze byc ujemna. Podaj poprawna wartosc:");
            } while (cena < 0);
            return (cena);
        }

        static double Wczytaj_rocznik()
        {
            double rocznik;
            do
            {
                rocznik = double.Parse(Console.ReadLine());
                if (rocznik < 0)
                    Console.WriteLine("Rocznik nie moze byc ujemny, ani ulamkiem. Podaj poprawna wartosc:");
            } while (rocznik < 0 || (int)rocznik!=rocznik);
            return rocznik;
        }

        static double Wczytaj_przebieg()
        {
            double przebieg;
            do
            {
                przebieg = double.Parse(Console.ReadLine());
                if (przebieg < 0)
                    Console.WriteLine("Przebieg nie moze byc ujemny. Podaj poprawna wartosc:");
            } while (przebieg < 0);
            return przebieg;
        }

        static string Wczytaj_marke()
        {
            string marka;
            do
            {
                marka = Console.ReadLine();
                if (!marka.All(Char.IsLetter)) Console.WriteLine("Marka nie moze zawierac cyfr. Podaj poprawna wartosc:");
            } while (!marka.All(Char.IsLetter));
            return marka;
        }

        static void Wczytaj_Samochod(ref Samochod parametr)
        {
            Console.Write("Podaj cenę samochodu: ");
            parametr.cena = Wczytaj_cene();

            Console.Write("Podaj rocznik samochodu: ");
            parametr.rocznik = Wczytaj_rocznik();

            Console.Write("Podaj przebieg samochodu: ");
            parametr.przebieg = Wczytaj_przebieg();

            Console.Write("Podaj markę samochodu: ");
            parametr.marka = Wczytaj_marke();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość samochodów, ktrych inforacje chcesz podać");
            int n_aut = int.Parse(Console.ReadLine());
            Samochod[] samochody = new Samochod[n_aut];
            int j, n = 1, k = 1;
            for (j = 0; j <= n; j++)
            {
                Console.WriteLine("Informacja o {0} samochodzie: ", k);
                Wczytaj_Samochod(ref samochody[j]);
                k++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
