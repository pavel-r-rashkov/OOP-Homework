using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Bank.Accounts
{
    interface IWithdrawable
    {
        bool Withdraw(decimal amount);
    }
}
