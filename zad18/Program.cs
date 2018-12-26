using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad18
{
    class Program
    {
        // Napisz program, który wczyta ilość elementów ciągu liczb naturalnych oraz pobierze ich
        // wartości od użytkownika, a następnie wyświetli tylko parzyste.

        static void Main(string[] args)
        {
            uint tabValue;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj ilość elementów ciągu: ");
                uint.TryParse(Console.ReadLine(), out tabValue);
                if (tabValue != 0)
                {
                    uint[] tab = new uint[tabValue];
                    for (int i = 0; i < tab.Length; i++)
                    {
                        Console.Write($"Podaj wartość elementu ({i+1}): ");
                        uint.TryParse(Console.ReadLine(), out tab[i]);
                    }

                    Console.WriteLine("\nLiczby parzyste podanego ciagu: ");
                    foreach (var item in tab)
                    {
                        if (item % 2 == 0) Console.Write(item+" ");
                    }
                }
                else Console.WriteLine("Nie rozpoznaje liczby naturalnej.");


                Console.WriteLine("\n\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
