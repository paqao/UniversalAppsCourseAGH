using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Customer : ISystemUser
    {
        private decimal _money;

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

        public BankSystem BankSystem { get; set; }
        public void ShowInstruction()
        {
            throw new NotImplementedException();
        }


        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        
    }
}
