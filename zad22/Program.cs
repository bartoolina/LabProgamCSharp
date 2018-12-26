using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad22
{
    class Program
    {
        // Napisz program, w którym zainicjujesz tablicę zawierającą dziesięć imion i wypisz jej
        // elementy za pomocą pętli foreach. Wypisz na ekranie informacje, jakie imię losowo wybrał
        // program.
        static void Main(string[] args)
        {
            char key;
            do
            {
                Console.Clear();

                string[] names = new string[] { "Ola", "Michał", "Ala", "Łukasz", "Kasia", "Adam", "Basia", "Piotrek", "Asia", "Paweł" };

                Console.WriteLine("Imiona w tablicy:");
                foreach (var item in names)
                {
                    Console.Write(item + " ");
                }

                Random random = new Random();
                int result = random.Next(0, 9);
                Console.WriteLine($"\n\nLosowe imie nr {result+1} {names[result]}");

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
