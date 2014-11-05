using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class BankSystem
    {
        private List<Customer> _customers = new List<Customer>();

        public BankSystem()
        {
            
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
    }
}
