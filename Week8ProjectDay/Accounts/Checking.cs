using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay.Accounts
{
    class Checking : Account
    {
        private double overdraft;
        private double millionaire;

        public Checking(Random rand) : base(rand)
        {
            this.fileName = "CheckingAccountSummary.txt";
            this.type = "Checking";
            this.overdraft = 0;
            this.millionaire = 1000000;
        }

        public double Overdraft
        {
            get { return this.overdraft; }
        }

        public double Millionaire
        {
            get { return this.millionaire; }
        }

        public static void AcctOverdraft()
        {
            Console.Beep();
            Console.WriteLine("\t!!!Overdraft Alert!!! Your account now has a balance below $0.");
        }

        public static void AcctMillionaire()
        {
            Console.WriteLine("\tCongratulations! You are now a Millionaire!");
        }
    }
}
