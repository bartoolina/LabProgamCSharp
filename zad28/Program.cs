using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad28
{
    class Program
    {
        //Dla ciągu danego wzorem rekurencyjnym: a(1) = 1, a(n+1) = a(n)^2 - 3. Napisz funkcję, liczącą n-ty wyraz ciągu oraz napisz program obliczający jego wartość dla n podanego przez użytkownika.

        static double NtyWyraz(uint n)
        {
            if (n == 1) return 1;
            else  return Math.Pow( NtyWyraz( n-1 ) ,2 ) - 3;
            
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

                if (n != 0) Console.WriteLine("\nN-ty wyraz wynosi: {0}", NtyWyraz(n));
                else Console.WriteLine("\nPodałes błędną liczbę.");



                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
