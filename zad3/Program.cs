using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        //Napisz program, który wczytuje wartość promienia koła i wyświetla jego obwód i pole. Wyniki podaj z dokładnością do 2 miejsc po przecinku.
        static void Main(string[] args)
        {
            double radius;
            char key;
            do
            {
                Console.Clear();
                Console.Write("Podaj promień koła: ");
                Double.TryParse(Console.ReadLine(), out radius);

                Console.WriteLine("Obwód koła wynosi: {0:f2}", 2 * Math.PI * radius);
                Console.WriteLine("Pole koła wynosi: {0:f2}", Math.PI * radius * radius);

                Console.WriteLine("Chcesz obliczyc obwód i pole koła jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
