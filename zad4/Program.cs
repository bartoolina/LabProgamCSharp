using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        /*
        * Napisz program, który wczytuje długość promienia podstawy stożka oraz jego wysokość
        * i wyświetla na konsoli jego objętość i pole całkowite oraz długość tworzącej.Wyniki
        * wyświetl z dokładnością do 4 miejsc po przecinku.
        */
        static void Main(string[] args)
        {
            double radius, hight, capacity, area, generatix;
            char key;
            do
            {
                Console.Clear();

                Console.Write("Podaj długość promienia podstawy stożka: ");
                double.TryParse( Console.ReadLine(), out radius);
                Console.Write("Podaj wysokość stożka: ");
                double.TryParse(Console.ReadLine(), out hight);

                generatix = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(hight, 2));
                area = Math.PI * radius * (radius + generatix);
                capacity = (Math.PI * Math.Pow(radius, 2) * hight) / 3;

                Console.WriteLine($"\nTworząca ma długość {generatix:f4}\nPole całkowite wynosi {area:f4}\nObjętośc stozka to {capacity:f4}\n");

                Console.WriteLine("Chcesz dokonać obliczeń jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;

            } while (key == 'Y' || key == 'y');

        }
    }
}
