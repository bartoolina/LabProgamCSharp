using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad27
{
    class Program
    {
        //Napisz funkcję wyznaczającą n-ty wyraz ciągu Fibonacciego zadaną następującym wzorem: Napisz program, który oblicza wartość tej funkcji dla podanej przez użytkownika liczby naturalnej.

        static uint NtyWyraz (uint n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return NtyWyraz(n-1) + NtyWyraz(n-2);
        }

        static void Main(string[] args)
        {
            uint n;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj n wyraz do obliczenia: ");
                uint.TryParse(Console.ReadLine(), out n);

                Console.WriteLine("\nN wyraz wynosi: {0}", NtyWyraz(n));

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
