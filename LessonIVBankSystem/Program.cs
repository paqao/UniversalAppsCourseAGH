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
            Customer customer = new Customer();
            customer.Name = "Yolo";
            customer.LastName = "Swag";
            customer.Money = 123456;
            customer.CustomerId = 1;

            Customer.WriteCustomer(customer);

           // Customer customer = Customer.LoadCustomer(1234);
            //  Console.WriteLine("{0} {1} {2}",customer.Name,customer.LastName,customer.Money);
            BankSystem bankSystem = new BankSystem();
            bankSystem.StartWorking();
            /*BankOperator newOperator = new BankOperator();
            var debugValue = newOperator.CreatCustomer();
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
             */
        }
    }
}
