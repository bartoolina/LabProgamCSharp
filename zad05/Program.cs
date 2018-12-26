using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        //Napisz program, który informuje czy wczytana liczba rzeczywista jest dodatnia, ujemna czy równa 0. 
        static void Main(string[] args)
        {
            double number;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj dowlna liczbę: ");
                double.TryParse(Console.ReadLine(), out number);

                if (number > 0) Console.WriteLine("\nPodana Liczba jest większa od zera.");
                else if (number < 0) Console.WriteLine("\nPodana Liczba jest mniejsza od zera.");
                else Console.WriteLine("\nPdana liczba jest równa zero.");

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
