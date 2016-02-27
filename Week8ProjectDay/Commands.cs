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
        public Account account;
        public string accountFile = "AccountSummary.txt";


        public Commands()
        {
            client = new Client();
            account = new Account();

            this.WriteStream();
        }

        public void WriteStream()
        {
            StreamWriter writer = new StreamWriter(this.accountFile, false);

            writer.WriteLine("\t~~~~~~~~Account Summary~~~~~~~~");
            writer.WriteLine("Account Holder: " + client.Name());
            writer.WriteLine("Account Number: " + account.Id);
            writer.WriteLine();
            writer.WriteLine("Transaction Details:");
            writer.WriteLine();
            writer.Close();
            this.StreamFormat("Time Transaction Took Place", "Transaction Amount", "Balance");
        }

        public void ViewClientInformation()
        {
            Console.WriteLine("\t\tAccount Holder: " + client.Name());
            Console.WriteLine("\t\tAccount Number: " + account.Id);
            Console.WriteLine("\t\tAccount Created On: " + client.CreatedAt);
        }

        public void ViewAccountBalance()
        {
            Console.WriteLine("\tYour account balance is : " + this.account.Total.ToString("C2"));
            
        }

        public void StreamFormat(string time, string amount, string balance)
        {
            StreamWriter writer = new StreamWriter(this.accountFile, true);
            writer.WriteLine(String.Format("|{0,27}|{1,20}|{2,10}|", time, amount, balance));
            writer.Close();
        }

        public void DepositFunds()
        {
            Console.Write("\tPlease enter a deposit amount: $");
            string deposit = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(deposit, @"^\d+.?\d{0,4}$"))
                {
                    double depositAmount = double.Parse(deposit);
                    this.account.Deposit(depositAmount);
                    this.StreamFormat(DateTime.Now.ToString(), "+" + deposit, this.account.Total.ToString("C2"));
                    Console.WriteLine("\n\tThank you for your deposit of $" + deposit + "!");
                    break;
                }
                else
                {
                    Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                    deposit = Console.ReadLine();
                }
            } 
        }

        public void WithdrawFunds()
        {
            Console.Write("\tPlease enter the amount you wish to withdraw: $");
            string withdrawal = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(withdrawal, @"^\d+.?\d{0,4}$"))
                {
                    double withdrawalAmount = double.Parse(withdrawal);
                    this.account.Withdraw(withdrawalAmount);
                    this.StreamFormat(DateTime.Now.ToString(), "-" + withdrawal, this.account.Total.ToString("C2"));
                    Console.WriteLine("\n\tYour withdrawal of $" + withdrawal + " is complete!");
                    break;
                }
                else
                {
                    Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                    withdrawal = Console.ReadLine();
                }
            }    
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\n\tGoodbye! I hope you found your account summary helpful!\n");
            Environment.Exit(0);
        }

    }
}
