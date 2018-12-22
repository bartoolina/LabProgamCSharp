using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    class Program
    {
        /*
        * Napisz program, który sprawdza czy z podanych przez użytkownika 3 długości odcinków da się
        * zbudować trójkąt.Taki warunek jest spełniony, jeśli suma każdych dwóch odcinków jest większa
        * od trzeciego odcinka.
        */
        static void Main(string[] args)
        {
            char key;
            double[] lenght = new double[3];
            bool checkTriangle;
            do
            {
                Console.Clear();

                Console.WriteLine("Podaj trzy długości odcinków:");
                for (int i = 0; i < lenght.Length; i++)
                {
                    Console.Write( i+1+": ");
                    double.TryParse(Console.ReadLine(), out lenght[i]);
                }

                checkTriangle = true;
                if (!(lenght[0] + lenght[1] > lenght[2])) checkTriangle = false;
                if (!(lenght[1] + lenght[2] > lenght[0])) checkTriangle = false;
                if (!(lenght[2] + lenght[0] > lenght[1])) checkTriangle = false;

                if (checkTriangle) Console.WriteLine("Z podanych dlugości można stworzyć trójkąt.");
                else Console.WriteLine("Z podanych długości nie da się stworzyć trójkoąta.");

                Console.WriteLine("\nChcesz dokonać obliczeń jeszcze raz? [Y - yes]");
                key = Console.ReadKey().KeyChar;
            } while (key == 'Y' || key == 'y');
        }
    }
}
