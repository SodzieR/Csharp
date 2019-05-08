using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader Plik = new StreamReader(@"D:\Studenci\Biostatystyka I\Janucik Adrian\Cwiczenia z C#\CW26_input.txt");
            do {
                string new_line = Plik.ReadLine();
                new_line = new_line.Replace(" ", string.Empty);
                Console.WriteLine(new_line);
            } while (!Plik.EndOfStream);

            Console.WriteLine("");
            Console.WriteLine("Twoja przekrecona tablica wyglada nastepujaco");
            Console.WriteLine("");

            int lineCount = File.ReadLines(@"D:\Studenci\Biostatystyka I\Janucik Adrian\Cwiczenia z C#\CW26_input.txt").Count();

            string line_1 = Plik.ReadLine();
            string line_2 = Plik.ReadLine();
            string line_3 = Plik.ReadLine();
            string line_4 = Plik.ReadLine();
            string line_5 = Plik.ReadLine();
            string line_6 = Plik.ReadLine();
            string line_7 = Plik.ReadLine();
            string line_8 = Plik.ReadLine();
            string line_9 = Plik.ReadLine();
            string line_10 = Plik.ReadLine();

            Console.ReadKey();
        }
    }
}
