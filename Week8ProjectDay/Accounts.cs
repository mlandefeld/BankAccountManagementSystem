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
        public int account;
        //public static Random randNum = new Random();

        public int NewAcct()
        {
            Random randNum = new Random();
            account = randNum.Next(10000000, 100000000);
            return account;
           
        }

        public int Account
        {
            get { return this.account; }
            set { this.account = NewAcct(); }
        }
        
    }
}
