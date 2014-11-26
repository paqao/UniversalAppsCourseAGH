using System;
using System.IO;

namespace BankManagementLogic
{
    public class BankAdmin : BankWorker
    {
        private string _password;

        public BankAdmin()
        {
            using (var openStream = File.OpenText("admin.txt"))
            {
                _password = openStream.ReadLine();
            }
        }

        public BankAdmin CheckPassword(string passwordCandidate)
        {
            var hashValue = passwordCandidate.GetHashCode().ToString();

            if (hashValue == _password)
                return this;

            return null;
        }

        public override void Run()
        {
            string decision;
            do
            {
                ShowInstruction();
                decision = Console.ReadLine();

                if (String.IsNullOrEmpty(decision))
                    continue;

                if (decision.StartsWith("create"))
                {
                    string[] decistionPart = decision.Split(' ');
                }

            } while (System.String.CompareOrdinal(decision, "logout") != 0);
        }

        public override void ShowInstruction()
        {

            Console.WriteLine("********************************************************");
            Console.WriteLine("create operatorName operatorPass - to create an operator");
            Console.WriteLine("logout - to log out from application");
            Console.WriteLine();
        }

        public override void TransferMoney(Customer user2, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
