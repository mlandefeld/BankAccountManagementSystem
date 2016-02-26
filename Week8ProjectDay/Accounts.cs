using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class Accounts
    {
        //public string sdflkjsd = "";
        public int id;
        public float total;

        public Accounts()
        {
            this.id = MakeNewAccountNumber();
            this.total = 0;
        }

        public int Id
        {
            get { return this.id; }
        }

        public float Total
        {
            get { return this.total; }
            set { this.total = value; }
        }
        public float Deposit(float deposit)
        {
            this.total = this.total + deposit;
            return this.total;
        }

        public float Withdraw(float withdraw)
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
