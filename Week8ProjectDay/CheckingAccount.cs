using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class CheckingAccount : Account
    {
        //2 field, 2 property, 1 constructor
        //public override double total;
        public new double total;

        public /*override*/CheckingAccount()
        {
            this.total = 0;
        }

        public override double Total
        {
            get { return Math.Round(this.total, 2); }
            set { this.total = value; }
            
        }
        
        public override double Deposit(double deposit)
        {
            this.total = this.total + deposit;
            return base.Deposit(deposit);
        }


        public override double Withdraw(double withdraw)
        {
            this.total = this.total - withdraw;
            return this.total;
        }
        /*
        public double CheckingDeposit(double deposit)
        {
            this.checkingTotal = this.checkingTotal + deposit;
            return this.checkingTotal;
        }
        

        public double CheckingWithdraw(double withdraw)
        {
            this.checkingTotal = this.checkingTotal - withdraw;
            return this.checkingTotal;
        }
        

        public void ViewCheckingAccountBalance()
        {
            Console.WriteLine("\tYour account balance is : " + this.checkingAccount.Total.ToString("C2"));
        }
        */
    }
}
