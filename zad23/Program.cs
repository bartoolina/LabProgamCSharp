using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad23
{
    class Program
    {
        // Napisz funkcję obliczającą pole deltoida, której argumentami będą długości przekątnych deltoida.Przetestuj tą funkcję.

        static double PoleDeldoida (double _p, double _q)
        {
            return (_p * _q) / 2;
        }
        static void Main(string[] args)
        {
            double p, q;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj pierwszą przękątną deldoida: ");
                double.TryParse(Console.ReadLine(), out p);
                Console.Write("Podaj drugą przękątną deldoida: ");
                double.TryParse(Console.ReadLine(), out q);

                Console.WriteLine("\nPole deldoida o przękątnych {0} i {1}, wynosi {2}", p, q, PoleDeldoida(p,q));

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
