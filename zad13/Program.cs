using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad13
{
    class Program
    {
        //Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury. Użyj pętli for. 
        static void Main(string[] args)
        {
            uint length;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj wysokość boku trójkąta z liczb (n>1): ");
                uint.TryParse(Console.ReadLine(), out length);

                for (int i = 0; i <= length; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i*j+" ");
                    }
                    Console.WriteLine();

                }

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
