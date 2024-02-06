using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionAdapter;

namespace TransactionAdapter
{
    //Common interface which recieves and send money
    public class MoneyTransaction : IMoneyTransaction
    {
        private Bank _bank;
        private ShopVendor _shopVendor;
        public MoneyTransaction(Bank bank, ShopVendor shopVendor)
        {
            _bank = bank;
            _shopVendor = shopVendor;
        }
        public void TransferMoney(string from, string to, decimal amount)
        {
            if (to.StartsWith("*")) 
            {
                _shopVendor.ReceivePayment(from, amount);
            }
            else
            {
                _bank.MakeTransaction(from, to, amount);
            }
        }
    }
}
