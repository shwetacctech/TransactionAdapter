using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionAdapter;

namespace TransactionAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            ShopVendor vendor = new ShopVendor();

            //Initialization of adapter class
            IMoneyTransaction transactionAdapter = new MoneyTransaction(bank, vendor);

            //Two different transaction through same class
            transactionAdapter.TransferMoney("123456", "09876", 125);
            transactionAdapter.TransferMoney("123456", "*09876", 25);
            Console.ReadKey();
        }
    }
}
