using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BankManagementLogic
{
    public class BankSystem
    {
        private List<Customer> _customers = new List<Customer>();

        public BankSystem()
        {
           this._administrator = new BankAdmin();

            List<int> customersList = new List<int>();
            using (var file = File.OpenText("customers.txt"))
            {
                while (!file.EndOfStream)
                {
                    string tmp = file.ReadLine();
                    int tmpIntValue;
                    if (int.TryParse(tmp, out tmpIntValue))
                    {
                        customersList.Add(tmpIntValue);
                    }
                }
            }

            foreach (var customer in customersList)
            {
                _customers.Add(Customer.LoadCustomer(customer));
            }
        }

        public void SaveCustomer()
        {
            if(File.Exists("customers.txt"))
            {
                File.Delete("customers.txt");   
            }

            using (var file = File.CreateText("customers.txt"))
            {
                foreach (var customer in _customers)
                {
                    file.WriteLine(customer.CustomerId);
                }
            }
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
