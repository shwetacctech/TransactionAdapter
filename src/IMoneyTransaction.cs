using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionAdapter
{
    public interface IMoneyTransaction
    {
        void TransferMoney(string from, string to, decimal amount);
    }
}
