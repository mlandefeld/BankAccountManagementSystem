using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class ReserveAccount : Account
    {
        //2 field, 2 property, 1 constructor
        public double reserveTotal;

        public ReserveAccount()
        {
            this.reserveTotal = 0;
        }

        public double ReserveTotal
        {
            get { return Math.Round(this.reserveTotal, 2); }
            set { this.reserveTotal = value; }

        }
        public double ReserveDeposit(double deposit)
        {
            this.reserveTotal = this.reserveTotal + deposit;
            return this.reserveTotal;
        }

        public double ReserveWithdraw(double withdraw)
        {
            this.reserveTotal = this.reserveTotal - withdraw;
            return this.reserveTotal;
        }
    }
}
