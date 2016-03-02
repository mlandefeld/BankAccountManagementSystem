using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class SavingsAccount : Account
    {
        //2 field, 2 property, 1 constructor
        public double savingsTotal;

        public SavingsAccount()
        {
            this.savingsTotal = 0;
        }

        public double SavingsTotal
        {
            get { return Math.Round(this.savingsTotal, 2); }
            set { this.savingsTotal = value; }

        }

        public double SavingsDeposit(double deposit)
        {
            this.savingsTotal = this.savingsTotal + deposit;
            return this.savingsTotal;
        }

        public double SavingsWithdraw(double withdraw)
        {
            this.savingsTotal = this.savingsTotal - withdraw;
            return this.savingsTotal;
        }
    }
}
