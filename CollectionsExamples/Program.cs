using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] tablica = new int[30];
            for (int i = 0; i < 30; i++)
                tablica[i] = rand.Next();

            for (int i = 0; i < 30; i++)
                Console.WriteLine(tablica[i]);

            
            int[][] tablicaWielowymiarow = new int[30][];
            for (int i = 0; i < 30; i++)
            {
                tablicaWielowymiarow[i] = new int[20 + i];
            }

            int[,] kwadratowaTablica = new int[30, 20];
            var element = kwadratowaTablica[5, 19];

            int [,,,] duzaablica = new int[5, 10, 20, 30];

            // listy
            IList<int> listaInts = new List<int>();
            for (int i = 0; i  < 50; i++)
            {
                listaInts.Add(i + rand.Next());
            }
            listaInts.Insert(25, 0);
            Console.WriteLine("druga porcja");
            //for (int i = 0; i < 51; i++)
            //{
            //    Console.WriteLine(listaInts[i]);
            //}
            foreach (var listaInt in listaInts)
            {

                Console.WriteLine(listaInt);
            }

            // stos
            Stack<int> stackOfInts = new Stack<int>();
            stackOfInts.Push(30);
            stackOfInts.Push(20);
            int a = stackOfInts.Pop();
            Console.WriteLine(a);
            Console.ReadKey();

            Dictionary<string,int> dictionary = new Dictionary<string, int>();

            dictionary.Add("12345", 12345);
            dictionary["12356"] = 12356;
            if (dictionary.ContainsKey("12355"))
            {
                /// ... 
            }
            /*
            var jaggedArray = new int[10,30];
            int element = jaggedArray[1,5];*/
        }
    }
}
