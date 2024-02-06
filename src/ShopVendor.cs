using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionAdapter
{
    public class ShopVendor
    {
        //Recieveing payment logic 
        public void ReceivePayment(string fromCustomer, decimal amount)
        {
            Console.WriteLine($"\nReceiving payment of {amount} from customer {fromCustomer} at the shop.");

            Console.WriteLine($"Payment received successfully.\n");
        }
    }
}
