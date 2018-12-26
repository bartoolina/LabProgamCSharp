using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad21
{
    class Program
    {
        // Napisz program, który wygeneruje i wyświetli na ekranie hasło składające się z dużych liter,
        // którego długość będzie wygenerowaną losową liczbą z przedziału<10,20>.
        static void Main(string[] args)
        {
            char key;
            do
            {
                Console.Clear();

                Random random = new Random();
                Console.WriteLine("Generator hasła z dużych liter.");
                Console.WriteLine("(dl) 12345678901234567890");
                char[] tab = new char[random.Next(10, 20)];

                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = (char)random.Next(65, 90);
                }
                Console.WriteLine($"({tab.Length}) "+ new string (tab));


                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
