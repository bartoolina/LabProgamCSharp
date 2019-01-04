using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad26
{
    class Program
    {
        //Napisz funkcję rysującą na ekranie kwadrat o podanej długości boku, którego kontur jest wyrysowany znakiem nr 1, a wypełniony jest zadanym znak nr 2. Przetestuj działanie utworzonej procedury.

        static void Kwadrat (uint length, char edge, char fill)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || i == (length - 1) || j == 0 || j == (length - 1) ) Console.Write(edge);
                    else Console.Write(fill);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            uint lengthSquare;
            char key;
            do
            {
                Console.Clear();

                Console.Write("O jakiej długości boku narysować kwadrat? ");
                uint.TryParse(Console.ReadLine(), out lengthSquare);
                if (lengthSquare == 0) Console.WriteLine("Nie ma takiej kwadratu.");
                else Kwadrat(lengthSquare, '*', '+');

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
