using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8
{
    class Program
    {
        /*
        * Napisz program z użyciem instrukcji switch, który poprosi o dowolną ocenę w skali od 1 do 6:
        * - jeżeli będzie równa 1 odpisze, że to zła ocena,
        * - jeżeli będzie równa 2 odpisze, że to słaba ocena,
        * - jeżeli będzie równa 3 odpisze, że to przeciętna ocena,
        * - jeżeli będzie równa 4 odpisze, że to świetna ocena,
        * - jeżeli będzie równa 5 odpisze, że to wysoka ocena,
        * - jeżeli będzie równa 6 odpisze, że to rewelacyjna ocena,
        * - dla każdej innej wyświetli napis: "Miała być ocena, a nie dowolna liczba!" 
        */
        static void Main(string[] args)
        {
            double numbers;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj dowolną liczbe z zakresu 1-6: ");
                double.TryParse(Console.ReadLine(), out numbers);

                switch (numbers)
                {
                    case 1: Console.WriteLine("Jest to zła ocena!"); break;
                    case 2: Console.WriteLine("Jest to słaba ocena!"); break;
                    case 3: Console.WriteLine("Jest to przeciętna ocena!"); break;
                    case 4: Console.WriteLine("Jest to świetna ocena!"); break;
                    case 5: Console.WriteLine("Jest to wysoka ocena!"); break;
                    case 6: Console.WriteLine("Jest to rewelacyjna ocena!"); break;

                    default: Console.WriteLine("Miała być ocena, a nie dowolna liczba!"); break;

                }

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
            // dodalem komentarz
        
        }
    }
}
