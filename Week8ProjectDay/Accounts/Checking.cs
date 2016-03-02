using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay.Accounts
{
    class Checking : Account
    {
        public Checking() : base()
        {
            this.fileName = "CheckingAccountSummary.txt";
            this.type = "Checking";
        }
    }
}
