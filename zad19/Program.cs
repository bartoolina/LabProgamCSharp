using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad19
{
    class Program
    {
        //Napisz program, który wczyta od użytkownika zadeklarowaną przez niego ilość liczb naturalnych i wyświetli sumę kwadratów tych liczb.
        static void Main(string[] args)
        {
            uint tabValue;//, sum;
            uint[] tab;
            char key;
            do
            {
                Console.Clear();
                Console.Write("Ile chcesz podać liczb naturalnych? ");
                uint.TryParse(Console.ReadLine(), out tabValue);
                if (tabValue != 0)
                {
                    tab = new uint[tabValue];
                    for (int i = 0; i < tab.Length; i++)
                    {
                        Console.Write($"Podaj liczbe nr {i+1}: ");
                        uint.TryParse(Console.ReadLine(), out tab[i]);
                    }
                    uint sum = 0;
                    foreach (var item in tab)
                    {
                        sum += item * item;
                    }
                    Console.WriteLine($"\nSuma kwadratów podanych liczb wynosi {sum}.");
                }
                else Console.WriteLine("Nie podano prawidłowj liczby naturalnej.");


                    Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
