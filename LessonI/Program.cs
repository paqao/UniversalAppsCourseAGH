// To jest komentarz jednolinijkowy
/*
 * To jest komentarz wielolinijkowy
 */

// To są używane przestrzenie nazw (podłączone DLLki) zawierające
// istniejące klasy
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// To jest modyfikacja (lub stworzenie) przestrzeni nazw o nazwie LessonI
namespace LessonI
{
    // To jest definicja klasy Program
    class Program
    {
        /// <summary>
        /// To jest definicja metody klasy Program. Ten komentarz może posłużyć
        /// do stworzenia dokumentacji projektu.
        /// 
        /// Słówko static oznacza, że klasa nie musi być instancjonowana 
        /// (obiekt danej klasy nie musi być stworzony) by metoda była poprawnie
        /// wywołana
        /// 
        /// statyczna metoda Main może posłużyć jako klasa wejściowa do aplikacji
        /// i tak tutaj widzimy :)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
             * Wykorzystując przestrzeń nazw Console (Konsola) piszemy jedną
             * linę do konsoli. Linia ta zawiera string (który możemy stworzyć
             * pisząc tekst pomiędzy " ") `Hello World!`
             * */
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
