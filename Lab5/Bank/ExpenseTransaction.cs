using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Bank
{
    class ExpenseTransaction : Transaction
    {
        public override void ProcessTransaction()
        {
            Account.Expense -= Amount;
        }
    }
}
