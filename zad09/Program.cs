using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad9
{
    class Program
    {
        //Napisz program, który wypisze na ekranie wszystkie liczby podzielne przez 14 z przedziału od 0 do 200. 
        static void Main(string[] args)
        {
            char key;
            do
            {
                Console.Clear();

                Console.WriteLine("Wszystkie liczby podzielne przez 14 z zakresu 0-200.\n");
                for (int i = 0; i <= 200; i++)
                {
                    if (i%14==0)
                    {
                        Console.Write(i+" ");
                    }
                }

                Console.WriteLine("\n\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');

        }
    }
}
