using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class Account
    {
        //TODO: math.round(val,2) - rounds to two decimal places
        public int id;
        public double total;

        public Account()
        {
            this.id = MakeNewAccountNumber();
            this.total = 0;
        }

        public int Id
        {
            get { return this.id; }
        }

        public virtual double Total
        {
            get { return Math.Round(this.total, 2); }
            set { this.total = value; }
        }
        public virtual double Deposit(double deposit)
        {
            this.total = this.total + deposit;
            return this.total;
        }

        public virtual double Withdraw(double withdraw)
        {
            this.total = this.total - withdraw;
            return this.total;
        }

        public static int MakeNewAccountNumber()
        {
            Random randNum = new Random();
            return randNum.Next(10000000, 100000000);
        }
        
    }
}
