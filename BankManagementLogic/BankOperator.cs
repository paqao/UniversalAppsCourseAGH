using System;

namespace BankManagementLogic
{
    public class BankOperator : BankWorker
    {
        public Customer CreatCustomer()
        {
            var newCustomer = new Customer();
            Random rand = new Random();
            newCustomer.CustomerId = rand.Next();

            Console.WriteLine("Podaj imie");
            string line = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("Podaj imie");
                line = Console.ReadLine();
            }
            newCustomer.Name = line;

            Console.WriteLine("Podaj nazwisko");
            line = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("Podaj nazwisko");
                line = Console.ReadLine();
            }
            newCustomer.LastName = line;
           
        
            Console.WriteLine("Podaj ilosc pieniedzy");
            line = Console.ReadLine();
            decimal money=0;
            bool exit = false;
            do
            {
                if (decimal.TryParse(line, out money))
                {
                    if (money > 0.0M)
                    {
                        exit = true;
                        break;
                    }
                }
                Console.WriteLine("Podaj ilosc pieniedzy");
                line = Console.ReadLine();
            } while (!exit);

            newCustomer.Money = money;

            return newCustomer;
        }

        public override void TransferMoney(Customer user2, decimal amount)
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override void ShowInstruction()
        {
            throw new NotImplementedException();
        }
    }
}
