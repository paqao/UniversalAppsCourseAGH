using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class BankOperator : BankWorker
    {
        public Customer CreatCustomer()
        {
            return new Customer();
        }
    }
}
