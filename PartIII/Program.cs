using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartIII
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Korzystając z wiedzy zdobytej dzisiaj na spotkaniu stwórz
             * swego rodzaju "brainf*ck", który posiada polecenia
             * * inc - zwiększa licznik o jeden
             * * dec - zmniejsza licznik o jeden
             * * print - wypisuje wartość licznika
             * * save [liczba] - wprowadza nową wartość z "liczba"
             *      Int.TryParse
             * * zero - zeruje licznik
             * * exit - wychodzi z programu
             * Program powinien zachowywać standardy nazewnictwa.
             */

            int counter = 0;
            string command = "";

            while (command != "exit")
            {
                if (command == "inc")
                {
                    counter++;
                }
                else if (command == "dec")
                {
                    counter--;

                }
                else if (command == "print")
                {
                    Console.WriteLine(counter );
                    
                  
                }
                else if (!String.IsNullOrEmpty(command) && command.StartsWith("save"))
                {
                    var splited = command.Split(' ');
                    if (splited.Length > 1)
                    {
                        Int32 tmpValue;
                        bool result =Int32.TryParse(splited[1], out tmpValue);
                        if (result)
                            counter = (int)tmpValue;
                    }
                }
                else if (command == "zero")
                {
                    counter = 0;
                }

                command = Console.ReadLine();
            }
        }
    }
}
