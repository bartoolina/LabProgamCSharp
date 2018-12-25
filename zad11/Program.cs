using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad11
{
    class Program
    {
        /*
        * Napisz program, który wczyta rok początkowy i rok końcowy, a następnie dla tego
        * przedziału lat, wypisze wszystkie lata przestępne. Przyjmujemy, że dla podanych lat,
        * przedział jest obustronnie domknięty. Rok przestępny spełnia następujące warunki: albo
        * jest podzielny przez 4 i jednocześnie niepodzielny przez 100 albo jest podzielny przez 400.
        */ 
        static void Main(string[] args)
        {
            uint startYear, endYear, counter;
            char key;
            do
            {
                Console.Clear();
                counter = 0;
                Console.WriteLine("program do obliczanaia lat przęstępnych");
                Console.Write("Podaj rok początkowy: ");
                uint.TryParse(Console.ReadLine(), out startYear);
                Console.Write("Podaj rok końcowy: ");
                uint.TryParse(Console.ReadLine(), out endYear);
                

                if (startYear < 1 || endYear < 1) Console.WriteLine("Podałeś niepoprawne lata.");
                else
                {
                    Console.WriteLine("\nObliczanie ze wzrou:");
                    for (uint i = startYear; i < endYear; i++)
                    {
                        if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                        {
                            Console.Write(i + " ");
                            if (++counter == 10)
                            {
                                Console.WriteLine();
                                counter = 0;
                            }
                        
                        }
                        
                    }

                    counter = 0;
                    Console.WriteLine("\n\nObliczanie z wbudowanej klasy:");
                    for (uint i = startYear; i < endYear; i++)
                    {
                        if ( DateTime.IsLeapYear((int)i) )
                        {
                            Console.Write(i + " ");
                            if (++counter == 10)
                            {
                                Console.WriteLine();
                                counter = 0;
                            }
                        }
                    }
                }

                Console.WriteLine("\n\nChcesz dokonać obliczeń jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');

        }
    }
}
