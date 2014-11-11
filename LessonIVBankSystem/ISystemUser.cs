using System;

namespace BankSystem
{
    internal interface ISystemUser
    {
        void TransferMoney(Customer user2, decimal amount);

        event EventHandler<OnUserLogoutEventArgs> OnUserLogout;
        void Run();

        BankSystem BankSystem { get; set; }

        void ShowInstruction();
    }
}