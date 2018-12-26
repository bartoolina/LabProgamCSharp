using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {

        //Napisz program, który wczytuje liczbę naturalną n i podaje sumę ciągu n kolejnych liczb naturalnych.Skorzystaj z gotowego wzoru na taką sumę. 
        static void Main(string[] args)
        {
            
            int number;
            char key;

            do
            {
                try
                {
                    Console.Clear();
                    Console.Write("Podaj liczbę: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Suma ciągu wynosi: {0}", number * (number + 1) / 2);
                }
                catch (Exception)
                {
                    Console.WriteLine("To nie jest prawidłowa liczba!");
                }
                finally
                {
                    Console.WriteLine("Czy chcesz spróbować jeszce raz? [Y = Yes]");
                    key = Console.ReadKey().KeyChar;

                }
            } while (key == 'y' || key == 'Y');

            //Console.ReadKey();
        }
    }
}
