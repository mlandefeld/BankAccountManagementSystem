﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay.Accounts
{
    class Reserve : Account
    {
        public Reserve() : base()
        {
            this.fileName = "ReserveAccountSummary.txt";
            this.type = "Reserve";
        }
    }
}
