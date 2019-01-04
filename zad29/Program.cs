using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad29
{
    class Program
    {
        //Zaimplementuj wersję rekurencyjną algorytmu Euklidesa umożliwiającego obliczenie największego wspólnego dzielnika.Przetestuj utworzoną funkcję rekurencyjną.

        static double Euklides(uint a, uint b)
        {
            if (a % b == 0) return b;
            else return Euklides(b, a % b);
        }

        static void Main(string[] args)
        {
            uint first, second, temp;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj pierwsza liczbe: ");
                uint.TryParse(Console.ReadLine(), out first);

                Console.Write("Podaj drugą liczbe: ");
                uint.TryParse(Console.ReadLine(), out second);

                if (first < second)
                {
                    temp = first;
                    first = second;
                    second = temp;
                }

                Console.WriteLine("\nNajwiększy wspólny dzielnik wynosi: {0}", Euklides(first, second));

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
