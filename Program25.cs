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
            string new_line;
            StreamWriter Plik = new StreamWriter(@"D:\Studenci\Biostatystyka I\Janucik Adrian\Cwiczenia z C#\CW25.txt", true);
            Console.WriteLine("Wpisz swoj tekst");
            do
            {

                new_line = Console.ReadLine();
                Plik.WriteLine(new_line);
                
            } while (!string.IsNullOrEmpty(new_line));
            Plik.Close();
        }
    }
}
