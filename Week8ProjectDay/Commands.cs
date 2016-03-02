using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Week8ProjectDay
{
    class Commands
    {
        public Client client;
        public string checkingAccountFile = "CheckingAccountSummary.txt";
        public string reserveAccountFile = "ReserveAccountSummary.txt";
        public string savingsAccountFile = "SavingsAccountSummary.txt";
        public CheckingAccount checkingAccount;
        public ReserveAccount reserveAccount;
        public SavingsAccount savingsAccount;

        public Commands()
        {
            this.client = new Client();
            this.checkingAccount = new CheckingAccount();
            this.reserveAccount = new ReserveAccount();
            this.savingsAccount = new SavingsAccount();

            this.WriteStream("Checking",this.checkingAccountFile, this.checkingAccount);
            this.WriteStream("Reserve", this.reserveAccountFile, this.reserveAccount);
            this.WriteStream("Savings", this.savingsAccountFile, this.savingsAccount);
        }

        public void WriteStream(string type, string file, Account account)
        {
            StreamWriter writer = new StreamWriter(file, false);

            writer.WriteLine("\t~~~~~~~~Account Summary~~~~~~~~");
            writer.WriteLine("Account Holder: " + this.client.Name());
            writer.WriteLine("Account Number: " + account.Id);
            writer.WriteLine("Account Type: " + type);
            writer.WriteLine();
            writer.WriteLine("Transaction Details:");
            writer.WriteLine();
            writer.Close();
            this.StreamFormat("Time Transaction Took Place", "Transaction Amount", "Balance", file);
        }


        public void ViewClientInformation(Account account)
        {
            Console.WriteLine("\t\tAccount Holder: " + this.client.Name());
            Console.WriteLine("\t\tAccount Number: " + account.Id);
            Console.WriteLine("\t\tAccount Created On: " + this.client.CreatedAt);
        }
        
        public void ViewAccountBalance(Account account)
        {
            Console.WriteLine("\tYour account balance is : " + account.Total.ToString("C2"));
        }
        

        public void StreamFormat(string time, string amount, string balance, string file)
        {
            StreamWriter writer = new StreamWriter(file, true);
            writer.WriteLine(String.Format("|{0,27}|{1,20}|{2,10}|", time, amount, balance));
            writer.Close();
        }

        public void DepositFunds(Account account, string file)
        {
            Console.Write("\tPlease enter a deposit amount: $");
            string deposit = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(deposit, @"^\d+.?\d{0,4}$"))
                {
                    double depositAmount = double.Parse(deposit);
                    account.Deposit(depositAmount);
                    this.StreamFormat(DateTime.Now.ToString(), "+" + deposit, account.Total.ToString("C2"), file);
                    Console.WriteLine("\n\tThank you for your deposit of $" + deposit + "!");
                    break;
                }
                else
                {
                    Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                    deposit = Console.ReadLine();
                }
            }

            /*
            Console.WriteLine("\tWhich account would you like to deposit funds into?");
            Console.Write("\t1.Checking Account\n\t2.Reserve Account\n\t3.Savings Account\n\t");
            string input = Console.ReadLine();
           
                else
                {
                    Console.WriteLine("\tOops! Choose an account you would like to deposit funds into!");
                    Console.Write("\t");
                    input = Console.ReadLine();
                }
            }
             */
        }

        public void WithdrawFunds(Account account, string file)
        {
            Console.Write("\tPlease enter the amount you wish to withdraw: $");
            string withdrawal = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(withdrawal, @"^\d+.?\d{0,4}$"))
                {
                    double withdrawalAmount = double.Parse(withdrawal);
                    account.Withdraw(withdrawalAmount);
                    this.StreamFormat(DateTime.Now.ToString(), "-" + withdrawal, account.Total.ToString("C2"), file);
                    Console.WriteLine("\n\tYour withdrawal of $" + withdrawal + " is complete!");
                    break;
                }
                else
                {
                    Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                    withdrawal = Console.ReadLine();
                }
            }
            /*
            Console.WriteLine("\tWhich account would you like to withdraw funds from?");
            Console.Write("\t1.Checking Account\n\t2.Reserve Account\n\t3.Savings Account\n\t");
            string input = Console.ReadLine();
            while (true)
            {
                }
                else
                {
                    Console.WriteLine("\tOops! Choose an account you would like to withdraw funds from!");
                    Console.Write("\t");
                    input = Console.ReadLine();
                }
            }    
            */
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\n\tGoodbye! I hope you found this bank account management system helpful!\n");
            Environment.Exit(0);
        }

    }
}
