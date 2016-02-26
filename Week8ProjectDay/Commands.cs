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
        public Clients client;
        public Accounts account;
        public string accountFile = "AccountSummary.txt";


        public Commands()
        {
            client = new Clients();
            account = new Accounts();

            this.WriteStream();
        }

        public void WriteStream()
        {
            StreamWriter writer = new StreamWriter(this.accountFile, false);

            writer.WriteLine("\t\t~~~~~~~~Account Summary~~~~~~~~");
            writer.WriteLine("Account Holder: " + client.Name);
            writer.WriteLine("Account Number: " + account.Id);
            writer.WriteLine();
            writer.WriteLine("Transaction Details:");
            writer.WriteLine();
            writer.WriteLine(String.Format("{0,20}{1,15}{2,15}", "|Time Transaction Took Place|", "|Transaction Amount|", "|Balance|"));
            writer.WriteLine(DateTime.Now);
            writer.WriteLine();
            writer.WriteLine("");
            writer.Close();
        }

        public void ViewClientInformation() //see defining classes slide #33
        {
            //streamread from .txt file
            Console.WriteLine("\t\tAccount Holder: " + client.Name);
            Console.WriteLine("\t\tAccount Number: " + account.Id);

        }

        public void ViewAccountBalance()
        {
            Console.WriteLine("\tYour account balance is : $" + this.account.Total);
            
        }

        public void DepositFunds()
        {
            Console.Write("\tPlease enter a deposit amount: $");
            string deposit = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(deposit, @"^\d+.?\d+$"))
                {
                    float depositAmount = float.Parse(deposit);
                    this.account.Deposit(depositAmount);
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
                if (Regex.IsMatch(withdrawal, @"^\d+.?\d+$"))
                {
                    float withdrawalAmount = float.Parse(withdrawal);
                    this.account.Withdraw(withdrawalAmount);
                    Console.WriteLine("\n\tYour withdrawal of " + withdrawal + " is complete!");
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
