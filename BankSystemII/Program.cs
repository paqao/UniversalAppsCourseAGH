using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();

            Customer c2 = new Customer();

            c1.Money = 10000000;
            c2.Money = 10;

            try
            {
                Console.WriteLine("{0} {1}",c1.Money, c2.Money);
                c1.TransferMoney(c2, 100);
                Console.WriteLine("{0} {1}", c1.Money, c2.Money);
                c2.TransferMoney(c1, 1000);
                Console.WriteLine("{0} {1}", c1.Money, c2.Money);
            }
            catch (ArgumentNullException e0)
            {
                Console.WriteLine(e0.Message);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            Console.ReadKey();
        }
    }
}
