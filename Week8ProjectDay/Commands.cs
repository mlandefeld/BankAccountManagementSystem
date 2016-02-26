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
            writer.WriteLine("Account Number: " + account.Account);
            writer.WriteLine();
            writer.WriteLine("Transactions:");
            writer.WriteLine(DateTime.Now);
            writer.WriteLine("");
            writer.Close();
        }

        public void ViewClientInformation() //see defining classes slide #33
        {
            //streamread from .txt file
            Console.WriteLine("\t\tAccount Holder: " + client.Name);
            Console.WriteLine("\t\tAccount Number: " + account.Account);

        }

        public void ViewAccountBalance()
        {

        }

        public void DepositFunds()
        {
            Console.Write("\tPlease enter a deposit amount: $");
            string deposit = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(deposit, @"^\d+.?\d+$"))
                {
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
            Console.Write("Please enter the amount you wish to withdraw: ");
            int withdrawal = int.Parse(Console.ReadLine());
            Console.WriteLine("Your withdrawal of " + withdrawal + "!");
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\n\tGoodbye! I hope you found your account summary helpful!\n");
            Environment.Exit(0);
        }

    }
}
