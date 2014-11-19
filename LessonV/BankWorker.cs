using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public abstract class BankWorker : ISystemUser
    {
        public abstract void TransferMoney(Customer user2, decimal amount);

        public event EventHandler<OnUserLogoutEventArgs> OnUserLogout;
        public abstract void Run();

        protected void RaiseOnUserLogout()
        {
            if(OnUserLogout != null)
                OnUserLogout(this, new OnUserLogoutEventArgs());
        }

        public BankSystem BankSystem { get; set; }
        public abstract void ShowInstruction();
    }
}
