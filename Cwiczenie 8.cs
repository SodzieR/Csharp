using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pole, R;
            Console.WriteLine("Podaj promień koła");
            R = double.Parse(Console.ReadLine());
            Pole = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Pole koła wynosi : {0,6:F4}",Pole);
            Console.ReadKey();


        }
    }
}
