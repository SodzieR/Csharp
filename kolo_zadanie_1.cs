using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kolokwium_Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"D:\Studenci\Biostatystyka I\Janucik Adrian\Kolokwium Zadanie 1\Zadanie_1_input.txt");
            StreamWriter file_parzyste = new StreamWriter(@"D:\Studenci\Biostatystyka I\Janucik Adrian\Kolokwium Zadanie 1\Zadanie_1_output_parzyste.txt", true);
            StreamWriter file_nieparzyste = new StreamWriter(@"D:\Studenci\Biostatystyka I\Janucik Adrian\Kolokwium Zadanie 1\Zadanie_1_output_nieparzyste.txt", true);
            string file_line = file.ReadLine();
            string[] numbers_string = file_line.Split(',');
            int[] numbers_int = new int[numbers_string.Length];
            int[] parzyste = new int[numbers_int.Length];
            int[] nieparzyste = new int[numbers_int.Length];
            for (int i = 0; i < numbers_string.Length; i++)
            {
                numbers_int[i] = Convert.ToInt32(numbers_string[i]);
                if (numbers_int[i] % 2 == 0)
                {
                    parzyste[i] = numbers_int[i];
                    file_parzyste.Write(parzyste[i]+",");
                }
                else
                {
                    nieparzyste[i] = numbers_int[i];
                    file_nieparzyste.Write(nieparzyste[i] + ",");
                }
            }
            file_parzyste.Close();
            file_nieparzyste.Close();
            Console.ReadKey();
        }
    }
}
