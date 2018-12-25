using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad12
{
    class Program
    {
        //Wczytaj liczbę naturalną n>1 i narysuj trójkąt prostokątny z gwiazdek z użyciem pętli for.
        static void Main(string[] args)
        {
            uint length;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj długość boku trójkąta z gwaizdek (n>1): ");
                uint.TryParse(Console.ReadLine(), out length);

                for (int i = 0; i <= length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
