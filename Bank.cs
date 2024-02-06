using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionAdapter
{
    public class Bank
    {
        //Money Transaction
        public void MakeTransaction(string fromAccount, string toAccount, decimal amount)
        {
            Console.WriteLine($"Processing bank transaction: \n");
            Console.WriteLine($"Transferring {amount} from account {fromAccount} to account {toAccount}.");
            Console.WriteLine($"Bank transaction completed successfully.\n");
        }
    }
}
