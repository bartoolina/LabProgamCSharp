using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad24
{
    class Program
    {
        // Napisz funkcję, która sprawdza czy rok jest przestępny i przetestuj ją.

        static bool CzyRokPrzestepny (uint year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            uint year;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj rok do sprawdzenia czy był przestępny: ");
                uint.TryParse(Console.ReadLine(), out year);

                if (CzyRokPrzestepny(year)) Console.WriteLine($"Rok {year} był przestepny");
                else Console.WriteLine($"Rok {year} nie był przestępny");

                Console.WriteLine("\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
