using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay.Accounts
{
    class Reserve : Account
    {
        public string whatReserve;
        public string reserveAcct;

        public Reserve() : base()
        {
            this.fileName = "ReserveAccountSummary.txt";
            this.type = "Reserve";
        }

        public Reserve(string whatReserve, string reserveAcct)
        {
            this.whatReserve = "This is a Reserve Account";
            this.reserveAcct = "A really cool Reserve Account";
        }

        public string WhatReserve
        {
            get { return this.whatReserve; }
        }

        public string ReserveAcct
        {
            get { return this.reserveAcct; }
        }

        public void ReserveReserve()
        {
            Console.WriteLine("I have no idea what you should use a reserve acct for...");
        }
    }
}
