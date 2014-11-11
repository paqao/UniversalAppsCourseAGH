using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class BankSystem
    {
        private List<Customer> _customers = new List<Customer>();

        public BankSystem()
        {
           this._administrator = new BankAdmin();
        }

        public Customer this[int customerId]
        {
            get
            {
                if (_customers.Count(x => (x.CustomerId == customerId)) > 0)
                {
                    return _customers.First(x => x.CustomerId == customerId);
                }
                return null;
            }
            
         
        }

        public void AddCustomer(Customer c )
        {
            _customers.Add(c);
        }

        public void StartWorking()
        {
            ShowWelcomeText(this, new OnUserLogoutEventArgs());

            string decision;

            do
            {
                ShowInstruction();
                decision = Console.ReadLine();

                if(String.IsNullOrEmpty(decision))
                    continue;

                if (decision.StartsWith("admin"))
                {
                    string[] decistionPart = decision.Split(' ');
                    var administrator = this.TryToLogAsAdmin(decistionPart[1]);
                    if (administrator == null)
                        Console.WriteLine("podales bledne haslo admina");
                    else 
                        administrator.Run();
                }

            } while (System.String.CompareOrdinal(decision, "exit")!=0);

            ShowExitText();
            Console.ReadKey();
        }

        private void ShowInstruction()
        {
            Console.WriteLine();
            Console.WriteLine("admin adminPass - to log as admin");
            Console.WriteLine("operator operatorName operatorPass - to log as operator");
            Console.WriteLine("customerId customerPass - to log as customer");
            Console.WriteLine("exit - to close application");
            Console.WriteLine();
        }

        private void ShowExitText()
        {
            Console.WriteLine("Zegnamy!");
        }

        private void ShowWelcomeText(object sender, OnUserLogoutEventArgs args)
        {
            Console.WriteLine("Witamy w systemie bankowym");
        }

        private BankAdmin _administrator;
        public BankAdmin TryToLogAsAdmin(string passwordCandidate)
        {

            return _administrator.CheckPassword(passwordCandidate);
        }
    }
}
