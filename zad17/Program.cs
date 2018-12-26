using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad17
{
    class Program
    {
        /*
        * Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich.
        * Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,
        * dla 2 – pola kwadratu, dla 3 – pola trójkąta, dla 4 – pola koła. Program powinien pytać
        * użytkownika, które pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0 (zero). 
        */
        static void Main(string[] args)
        {
            double a, b;
            char key='\0';
            do
            {
                Console.Clear();
                if (key != '\0')
                {
                    switch (key)
                    {
                        case '1':
                            {
                                Console.Write("Podaj krótszy bok: ");
                                double.TryParse(Console.ReadLine(), out a);
                                Console.Write("Podaj dłuższy bok: ");
                                double.TryParse(Console.ReadLine(), out b);
                                Console.WriteLine("\nPole prostąkota o bokach {0}, {1}, wynosi {2}.\n", a, b, a * b);
                                break;
                            }
                        case '2':
                            {
                                Console.Write("Podaj długość boku: ");
                                double.TryParse(Console.ReadLine(), out a);
                                Console.WriteLine("\nPole kwadratu o boku {0}, wynosi {1}.\n", a, a * a);
                                break;
                            }
                        case '3':
                            {
                                Console.Write("Podaj długość podstawy: ");
                                double.TryParse(Console.ReadLine(), out a);
                                Console.Write("Podaj wysokość trójkąta: ");
                                double.TryParse(Console.ReadLine(), out b);
                                Console.WriteLine("\nPole trójkąta o podstawie {0} i wysokości {1} wynosi {2}.\n", a, b, a * b / 2);
                                break;
                            }
                        case '4':
                            {
                                Console.Write("Podaj długość promienia: ");
                                double.TryParse(Console.ReadLine(), out a);
                                Console.WriteLine("\nPole koła o promieniu {0} wynosi {1:N4}.\n", a, Math.PI * a * a);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\nNie podano prawidłowej opcji.\n");
                                break;
                            }

                    }
                }

                Console.WriteLine("Program do obliczania pól firgur płaskich.");
                Console.WriteLine("1 - Obliczanie pola prostokąta");
                Console.WriteLine("2 - Obliczanie pola kwadratu");
                Console.WriteLine("3 - Obliczanie pola trójkota");
                Console.WriteLine("4 - Obliczanie pola koła");
                Console.WriteLine("0 - Zakończ program");
                Console.Write("\nCo Chesz zrobić? ");
                
                key = Console.ReadKey().KeyChar;

            } while (key != '0');
        }
    }
}
