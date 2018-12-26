using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01
{
    class Program
    {
        //Napisz program, który pyta o imię i wiek użytkownika i wyświetla komunikat: „Użytkownik o imieniu ….. ma …..lat.”
        static void Main(string[] args)
        {
            Console.Write("Podaj imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj ile masz lat: ");
            string age = Console.ReadLine();

            Console.WriteLine($"Masz na imię {firstName} i masz {age} lat.");


            Console.ReadKey();
        }
    }
}
