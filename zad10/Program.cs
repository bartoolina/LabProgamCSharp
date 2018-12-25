using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad10
{
    class Program
    {
        //Napisz program, który oblicza sumę n kolejnych liczb naturalnych (1+2+….+n) dla
        //podanego przez użytkownika n(n>2, n - naturalne). Użyj do tego celu pętli for. 
        static void Main(string[] args)
        {
            uint n;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj liczbe natrulna n, do obliczenia sumy ciągu (warunek n>2): ");
                uint.TryParse(Console.ReadLine(),out n);

                if (n < 3)  Console.WriteLine("Nie podałeś prawidłowej liczby."); 
                else
                {
                    uint result = (n * (n + 1U)) / 2U;
                    Console.WriteLine($"Suma ciągu o n-elementów równym {n}, wynosi {result}.");
                }

                Console.Write("\nChcesz spróbować jeszcze raz? [Y - yes] ");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
