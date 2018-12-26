using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad16
{
    class Program
    {
        // Napisz program, który narysuje na ekranie trójkąt, którego wysokość poda użytkownik. Użyj pętli while.
        static void Main(string[] args)
        {
            uint height, currentHeight, currentWidth;
            char key;
            do
            {
                Console.Clear();

                Console.WriteLine("Program do rysowania trójkoąta.");
                Console.Write("Podaj wysokość trójkąta: ");
                uint.TryParse(Console.ReadLine(), out height);

                if (height < 1) Console.WriteLine("Nieprawidłowa wartość!");
                else
                {
                    currentHeight = 1;
                    Console.WriteLine();
                    while (currentHeight<=height)
                    {
                        currentWidth = currentHeight;
                        while (currentWidth > 0)
                        {
                            Console.Write("*");
                            currentWidth--;
                        }
                        Console.WriteLine();
                        currentHeight++;
                    }
                }

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
