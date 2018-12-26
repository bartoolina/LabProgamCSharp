using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad15
{
    class Program
    {
        // Dany jest wzór ciągu a(n)=5n+2. Napisz program wczytujący liczbę całkowitą dodatnią n
        // i wypisujący na ekranie kolejne wyrazy ciągu: a(1), a(2), …, a(n). Użyj pętli do-while.
        static void Main(string[] args)
        {
            uint n, i;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Dany jest wzór ciągu a(n)=5n+2. Podaj n: ");
                uint.TryParse(Console.ReadLine(), out n);

                if (n < 1) Console.WriteLine("Nie podałeś prawidłowej liczby naturalnej.");
                else
                {
                    Console.WriteLine();
                    i = 0;
                    while (++i <= n) 
                    {
                        Console.WriteLine("a({1}) = {0}",5*i+2,i);
                    }
                }
                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
