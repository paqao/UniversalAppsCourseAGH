using System;

namespace BankManagementLogic
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

        public BankManagementLogic.BankSystem BankSystem { get; set; }
        public abstract void ShowInstruction();
    }
}
