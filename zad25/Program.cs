using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad25
{
    class Program
    {
        // Napisz funkcję, która znajduje największy wspólny dzielnik dla dwóch dowolnych liczb naturalnych i przestój tę funkcję. Skorzystaj z algorytmu Euklidesa.

        static uint NajwiekszyWspolnyDzielnik (uint a, uint b)
        {
            uint temp;

            while (a%b!=0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return b;
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

                if (first<second)
                {
                    temp = first;
                    first = second;
                    second = temp;
                }
                Console.WriteLine("\nNajwiększy wspólny dzielnik wynosi: {0}", NajwiekszyWspolnyDzielnik( first, second ));


                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
