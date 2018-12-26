using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad20
{
    class Program
    {
        // Wczytaj liczbę naturalną i wyświetl na ekranie jej postać w systemie ósemkowym. 
        static void Main(string[] args)
        {
            uint decimalNumber, tabValue, tmp;
            char key;
            do
            {
                Console.Clear();
                Console.Write("Podaj liczbe naturalna do zamiany na system ósemkowy: ");
                uint.TryParse(Console.ReadLine(), out decimalNumber);
                if (decimalNumber != 0)
                {
                    tabValue = 1;
                    tmp = 8;
                    while (decimalNumber>tmp)
                    {
                        tmp = tmp * 8;
                        tabValue++;
                    }
                    uint[] tab = new uint[tabValue];
                    tmp = 0;
                    while (decimalNumber>0)
                    {
                        tab[tmp++] = decimalNumber % 8;
                        decimalNumber = decimalNumber / 8;
                    }
                    Console.Write("\nLiczba w systemie ósemkowym: ");
                    for (int i = tab.Length-1; i >= 0; i--)
                    {
                        Console.Write(tab[i]);
                    }

                }
                else Console.Write("\nNie prawidłowa bądź za duża liczba.");

                Console.WriteLine("\n\nChcesz spróbować jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
