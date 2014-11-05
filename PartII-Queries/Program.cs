using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartII_Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            //  listae/
            List<string> sourceOfInts = new List<string>();

            Random rand = new Random();
            for (int i = 1000; i > 0; i--)
            {
                sourceOfInts.Add( (rand.Next() % 2500).ToString());
            }

            // where
            var result = sourceOfInts.Where(x => int.Parse(x) < 1000);
           
               result = sourceOfInts.Where(MyPredicate);
              
            var result2 = sourceOfInts.Select<string,int> (x => x.Length);
            foreach (var resultEntry in result)
            {
                Console.WriteLine(resultEntry);
            }

            var element = sourceOfInts.FirstOrDefault(x => x == "1");

            var count = sourceOfInts.Count(x => x.StartsWith("1"));

            sourceOfInts.Sort(new MyStringComparator());
  
            Console.ReadKey();
        }

        public static bool MyPredicate(string a)
        {
            return true;
        }
    }
}
