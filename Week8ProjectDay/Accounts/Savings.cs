using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay.Accounts
{
    class Savings : Account
    {
        public double superSaver;
        public double badSaver;

        public Savings() : base()
        {
            this.fileName = "SavingsAccountSummary.txt";
            this.type = "Savings";
        }

        public Savings(double superSaver, double badSaver)
        {
            this.superSaver = 0;
            this.badSaver = 0;
        }

        public double SuperSaver
        {
            get { return this.superSaver; }
        }

        public double BadSaver
        {
            get { return this.badSaver; }
        }

        public void AcctSuperSaver()
        {
            Console.WriteLine("\tCongratulations! You are a super saver and are set for life!");
        }

        public void AcctBadSaver()
        {
            Console.WriteLine("\t!Bank Alert! Your balance is low; you might overdraft soon.");
        }
    }
}
