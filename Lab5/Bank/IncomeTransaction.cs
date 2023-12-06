using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Bank
{
    class IncomeTransaction : Transaction
    {
        public override void ProcessTransaction()
        {
            Account.Income += Amount;
        }
    }
}
