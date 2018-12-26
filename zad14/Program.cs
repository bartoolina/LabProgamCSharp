using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad14
{
    class Program
    {
        //Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z przedziału[a, b]. Użyj pętli while.
        static void Main(string[] args)
        {
            uint a, b, i;
            char key;
            do
            {
                Console.Clear();

                Console.WriteLine("Program do wyznaczania liczb parzystych z przedziału <a,b>.");
                Console.Write("Podaj liczbę naturalna większą od 0: ");
                uint.TryParse(Console.ReadLine(), out a);
                Console.Write($"Podaj liczbę naturalną większą od {a}: ");
                uint.TryParse(Console.ReadLine(), out b);

                if (a < 1 || b < 1) Console.WriteLine("Nie podałeś liczb z wymaganego zakresu.");
                else
                {
                    i = a;
                    while (i <= b)
                    {
                        if (i%2==0) Console.Write(i+" ");
                        i++;
                    }
                }
                Console.WriteLine("\n\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
