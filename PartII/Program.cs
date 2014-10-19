using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Przestrzenie nazw piszemy z dużych liter
namespace PartII
{
    // nazwy klas również
    class Program
    {
        /*
         * pole prywatne -dostępne jedynie wewnątrz klasy
         * statyczne - wszystkie instance mają taką samą wartość tego pola
         * int - typ pola
         * standard podkreślenie i później wyraz z małej
         */
        private static int _counter = 0; // licznik
        // Nazwy metod - duże litery :), argumenty CamelCase
        static void Main(string[] args)
        {
            string providedCommand = "";

            while (providedCommand != "exit") // pracujemy dopóki wprowadzony string będzie różny od exit
            {
                _counter ++;
                Console.Write("{0} >> ", _counter);
                providedCommand = Console.ReadLine();
            }
        }
    }
}
