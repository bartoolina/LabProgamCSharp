using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    class Program
    {
        // Napisz program, który wczytuje 6 liczb i wyświetla na ekranie najmniejszą. 
        static void Main(string[] args)
        {
            char key;
            double[] numbers = new double[6];
            double minNumber; 
            do
            {
                Console.Clear();

                Console.WriteLine("Podaj sześć liczb:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(i + 1 + ": ");
                    double.TryParse(Console.ReadLine(), out numbers[i]);
                }

                minNumber = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < minNumber) minNumber = numbers[i];
                }

                Console.WriteLine($"Najmniejsza z podanych liczb to {minNumber}.");

                Console.WriteLine("\nChcesz dokonać obliczeń jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
