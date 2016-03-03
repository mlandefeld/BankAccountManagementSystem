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

        public Commands()
        {
            this.client = new Client();

            foreach (Account account in this.client.accounts)
            {
                this.WriteStream(account);
            }
        }
        
        public void WriteStream(Account account)
        {
            StreamWriter writer = new StreamWriter(account.FileName, false);

            writer.WriteLine("\t~~~~~~~~Account Summary~~~~~~~~");
            writer.WriteLine("Account Holder: " + this.client.Name());
            writer.WriteLine("Account Number: " + account.Id);
            writer.WriteLine("Account Type: " + account.Type);
            writer.WriteLine();
            writer.WriteLine("Transaction Details:");
            writer.WriteLine();
            writer.Close();
            this.StreamFormat("Time Transaction Took Place", "Transaction Amount", "Balance", account.FileName);
        }

        public void ViewClientInformation(string type)
        {
            Account account = this.client.Accounts.Find(x => x.Type == type);

            Console.WriteLine("\t\tAccount Holder: " + this.client.Name());
            Console.WriteLine("\t\tAccount Number: " + account.Id);
            Console.WriteLine("\t\tAccount Type: " + account.Type);
            Console.WriteLine("\t\tAccount Created On: " + this.client.CreatedAt);

        }

        public void ViewAccountBalance(string type)
        {
            Account account = this.client.Accounts.Find(x => x.Type == type);
            Console.WriteLine("\tYour account balance is : " + account.Total.ToString("C2"));
        }

        public void StreamFormat(string time, string amount, string balance, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine(String.Format("|{0,27}|{1,20}|{2,10}|", time, amount, balance));
            writer.Close();
        }

        public void DepositFunds(string type)
        {
            Account account = this.client.Accounts.Find(x => x.Type == type);
            
            Console.Write("\tPlease enter a deposit amount: $");
            string deposit = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(deposit, @"^\d+.?\d{0,4}$"))
                {
                    double depositAmount = double.Parse(deposit);
                    account.Deposit(depositAmount);
                    this.StreamFormat(DateTime.Now.ToString(), "+" + deposit, account.Total.ToString("C2"), account.FileName);
                    Console.WriteLine("\n\tThank you for your deposit of $" + deposit + "!");
                    break;
                }
                else
                {
                    Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                    Console.Write("\t");
                    deposit = Console.ReadLine();
                }
            }
        }

        public void WithdrawFunds(string type)
        {
            Account account = this.client.Accounts.Find(x => x.Type == type);

            Console.Write("\tPlease enter the amount you wish to withdraw: $");
            string withdrawal = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(withdrawal, @"^\d+.?\d{0,4}$"))
                {
                    double withdrawalAmount = double.Parse(withdrawal);
                    account.Withdraw(withdrawalAmount);
                    this.StreamFormat(DateTime.Now.ToString(), "-" + withdrawal, account.Total.ToString("C2"), account.FileName);
                    Console.WriteLine("\n\tYour withdrawal of $" + withdrawal + " is complete!");
                    break;
                }
                else
                {
                    Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                    Console.Write("\t");
                    withdrawal = Console.ReadLine();
                }
            }
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\n\tGoodbye! I hope you found this bank account management system helpful!\n");
            Environment.Exit(0);
        }

    }
}
