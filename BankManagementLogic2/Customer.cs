using System;
using System.IO;

namespace BankManagementLogic
{
    public class Customer : ISystemUser
    {
        private decimal _money;

        public static Customer LoadCustomer(int customerId)
        {
            Customer customer = new Customer();

            string path = customerId.ToString();
            using (var file = File.OpenText(path))
            {
                customer.CustomerId = customerId;

                customer.Name = file.ReadLine();
                customer.LastName = file.ReadLine();

                decimal money;
                decimal.TryParse(file.ReadLine(), out money);
                customer.Money = money;
            }

            return customer;
        }

        public static void WriteCustomer(Customer customer)
        {
            string path = customer.CustomerId.ToString();

            if(File.Exists(path))
                File.Delete(path);

            using (var file = File.CreateText(path))
            {
                file.WriteLine(customer.Name);
                file.WriteLine(customer.LastName);
                file.WriteLine(customer.Money.ToString());
            }
        }

        public decimal Money
        {
            get { return _money; }
            set { _money = value; }
        }

        public void TransferMoney(Customer user2, decimal amount)
        {
            if (user2 == null)
            {
                throw new ArgumentNullException();
            }
            if (amount <= 0)
            {
                throw new Exception("naucz się matematyki");
            }
            if (this.Money < amount)
            {
                throw new Exception("jestes za biedny");
            }

            this.Money -= amount;
            user2.Money += amount;
        }

        public event EventHandler<OnUserLogoutEventArgs> OnUserLogout;
        public void Run()
        {
            throw new NotImplementedException();
        }

        public BankManagementLogic.BankSystem BankSystem { get; set; }
        public void ShowInstruction()
        {
            throw new NotImplementedException();
        }


        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        
    }
}
