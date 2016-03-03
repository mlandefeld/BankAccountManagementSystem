using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay.Accounts
{
    class Savings : Account
    {

        public Savings() : base()
        {
            this.fileName = "SavingsAccountSummary.txt";
            this.type = "Savings";
        }

    }
}
