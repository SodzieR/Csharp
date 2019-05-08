using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst zawierajacy liczby odzdielone przecinakmi");
            string txt = Console.ReadLine();
            char[] separator = { ',' };
            string[] txt_table = txt.Split(separator);
            txt_table.Trim([, tablicaznaków]);
        }
    }
}
