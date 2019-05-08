using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            StreamReader Plik = new StreamReader(@"D:\Studenci\Biostatystyka I\Janucik Adrian\Cwiczenia z C#\txt.txt");
            do
            {
                Console.WriteLine(Plik.ReadLine());
            } while(!Plik.EndOfStream);
            Console.ReadKey();
        }
    }
}
