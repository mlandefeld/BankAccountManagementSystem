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
        public string checkingaccountFile = "CheckingAccountSummary.txt";
        public string reserveaccountFile = "ReserveAccountSummary.txt";
        public string savingsaccountFile = "SavingsAccountSummary.txt";
        public CheckingAccount checkingAccount;
        public ReserveAccount reserveAccount;
        public SavingsAccount savingsAccount;

        public Commands()
        {
            this.client = new Client();
            this.account = new Account();
            this.checkingAccount = new CheckingAccount();
            this.reserveAccount = new ReserveAccount();
            this.savingsAccount = new SavingsAccount();
            this.WriteStreamChecking();
            this.WriteStreamReserve();
            this.WriteStreamSavings();
        }

        public void WriteStreamChecking()
        {
            StreamWriter writer = new StreamWriter(this.checkingaccountFile, false);

            writer.WriteLine("\t~~~~~~~~Account Summary~~~~~~~~");
            writer.WriteLine("Account Holder: " + this.client.Name());
            writer.WriteLine("Account Number: " + this.account.Id);
            writer.WriteLine("Account Type: Checking");
            writer.WriteLine();
            writer.WriteLine("Transaction Details:");
            writer.WriteLine();
            writer.Close();
            this.StreamFormatChecking("Time Transaction Took Place", "Transaction Amount", "Balance");
        }

        public void WriteStreamReserve()
        {
            StreamWriter writer = new StreamWriter(this.reserveaccountFile, false);

            writer.WriteLine("\t~~~~~~~~Account Summary~~~~~~~~");
            writer.WriteLine("Account Holder: " + this.client.Name());
            writer.WriteLine("Account Number: " + this.account.Id);
            writer.WriteLine("Account Type: Reserve");
            writer.WriteLine();
            writer.WriteLine("Transaction Details:");
            writer.WriteLine();
            writer.Close();
            this.StreamFormatReserve("Time Transaction Took Place", "Transaction Amount", "Balance");
        }

        public void WriteStreamSavings()
        {
            StreamWriter writer = new StreamWriter(this.savingsaccountFile, false);

            writer.WriteLine("\t~~~~~~~~Account Summary~~~~~~~~");
            writer.WriteLine("Account Holder: " + this.client.Name());
            writer.WriteLine("Account Number: " + this.account.Id);
            writer.WriteLine("Account Type: Savings");
            writer.WriteLine();
            writer.WriteLine("Transaction Details:");
            writer.WriteLine();
            writer.Close();
            this.StreamFormatSavings("Time Transaction Took Place", "Transaction Amount", "Balance");
        }

        public void ViewClientInformation()
        {
            Console.WriteLine("\t\tAccount Holder: " + this.client.Name());
            Console.WriteLine("\t\tAccount Number: " + this.account.Id);
            Console.WriteLine("\t\tAccount Created On: " + this.client.CreatedAt);
        }
        /*
        public void ViewAccountBalance()
        {
            Console.WriteLine("\tYour account balance is : " + this.account.Total.ToString("C2"));
        }
        */
        
        public void ViewCheckingAccountBalance() //can this be in the CheckingAccount class instead?
        {
            Console.WriteLine("\tYour account balance is : " + this.checkingAccount.Total.ToString("C2"));
        }
        

        public void ViewReserveAccountBalance()
        {
            Console.WriteLine("\tYour account balance is : " + this.reserveAccount.ReserveTotal.ToString("C2"));
        }

        public void ViewSavingsAccountBalance()
        {
            Console.WriteLine("\tYour account balance is : " + this.savingsAccount.SavingsTotal.ToString("C2"));
        }

        public void StreamFormatChecking(string time, string amount, string balance)
        {
            StreamWriter writer = new StreamWriter(this.checkingaccountFile, true);
            writer.WriteLine(String.Format("|{0,27}|{1,20}|{2,10}|", time, amount, balance));
            writer.Close();
        }

        public void StreamFormatReserve(string time, string amount, string balance)
        {
            StreamWriter writer = new StreamWriter(this.reserveaccountFile, true);
            writer.WriteLine(String.Format("|{0,27}|{1,20}|{2,10}|", time, amount, balance));
            writer.Close();
        }

        public void StreamFormatSavings(string time, string amount, string balance)
        {
            StreamWriter writer = new StreamWriter(this.savingsaccountFile, true);
            writer.WriteLine(String.Format("|{0,27}|{1,20}|{2,10}|", time, amount, balance));
            writer.Close();
        }

        public void DepositFunds()
        {
            Console.WriteLine("\tWhich account would you like to deposit funds into?");
            Console.Write("\t1.Checking Account\n\t2.Reserve Account\n\t3.Savings Account\n\t");
            string input = Console.ReadLine();
            while (true)
            {
                if(input == "1")
                {
                    Console.Write("\tPlease enter a deposit amount: $");
                    string depositChecking = Console.ReadLine();
                    while (true)
                    {

                        if (Regex.IsMatch(depositChecking, @"^\d+.?\d{0,4}$"))
                        {
                            double depositAmount = double.Parse(depositChecking);
                            this.account.Deposit(depositAmount);
                            this.StreamFormatChecking(DateTime.Now.ToString(), "+" + depositChecking, this.checkingAccount.Total.ToString("C2"));
                            Console.WriteLine("\n\tThank you for your deposit of $" + depositChecking + "!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                            depositChecking = Console.ReadLine();
                        }
                    }
                    break;
                }
                else if (input == "2")
                {
                    Console.Write("\tPlease enter a deposit amount: $");
                    string depositReserve = Console.ReadLine();
                    while (true)
                    {

                        if (Regex.IsMatch(depositReserve, @"^\d+.?\d{0,4}$"))
                        {
                            double depositAmount = double.Parse(depositReserve);
                            this.account.Deposit(depositAmount);
                            this.StreamFormatChecking(DateTime.Now.ToString(), "+" + depositReserve, this.reserveAccount.ReserveTotal.ToString("C2"));
                            Console.WriteLine("\n\tThank you for your deposit of $" + depositReserve + "!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                            depositReserve = Console.ReadLine();
                        }
                    }
                    break;
                }
                else if (input =="3")
                {
                    Console.Write("\tPlease enter a deposit amount: $");
                    string depositSavings = Console.ReadLine();
                    while (true)
                    {

                        if (Regex.IsMatch(depositSavings, @"^\d+.?\d{0,4}$"))
                        {
                            double depositAmount = double.Parse(depositSavings);
                            this.account.Deposit(depositAmount);
                            this.StreamFormatChecking(DateTime.Now.ToString(), "+" + depositSavings, this.savingsAccount.SavingsTotal.ToString("C2"));
                            Console.WriteLine("\n\tThank you for your deposit of $" + depositSavings + "!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                            depositSavings = Console.ReadLine();
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\tOops! Choose an account you would like to deposit funds into!");
                    Console.Write("\t");
                    input = Console.ReadLine();
                }
            }
             
        }

        public void WithdrawFunds()
        {
            Console.WriteLine("\tWhich account would you like to withdraw funds from?");
            Console.Write("\t1.Checking Account\n\t2.Reserve Account\n\t3.Savings Account\n\t");
            string input = Console.ReadLine();
            while (true)
            {
                if (input =="1")
                {
                    Console.Write("\tPlease enter the amount you wish to withdraw: $");
                    string withdrawal = Console.ReadLine();
                    while (true)
                    {
                        if (Regex.IsMatch(withdrawal, @"^\d+.?\d{0,4}$"))
                        {
                            double withdrawalAmount = double.Parse(withdrawal);
                            this.account.Withdraw(withdrawalAmount);
                            this.StreamFormatChecking(DateTime.Now.ToString(), "-" + withdrawal, this.checkingAccount.Total.ToString("C2"));
                            Console.WriteLine("\n\tYour withdrawal of $" + withdrawal + " is complete!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                            withdrawal = Console.ReadLine();
                        }
                    }
                    break;
                }
                else if (input == "2")
                {
                    Console.Write("\tPlease enter the amount you wish to withdraw: $");
                    string withdrawal = Console.ReadLine();
                    while (true)
                    {
                        if (Regex.IsMatch(withdrawal, @"^\d+.?\d{0,4}$"))
                        {
                            double withdrawalAmount = double.Parse(withdrawal);
                            this.account.Withdraw(withdrawalAmount);
                            this.StreamFormatReserve(DateTime.Now.ToString(), "-" + withdrawal, this.reserveAccount.ReserveTotal.ToString("C2"));
                            Console.WriteLine("\n\tYour withdrawal of $" + withdrawal + " is complete!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                            withdrawal = Console.ReadLine();
                        }
                    }
                    break;
                }
                else if(input =="3")
                {
                    Console.Write("\tPlease enter the amount you wish to withdraw: $");
                    string withdrawal = Console.ReadLine();
                    while (true)
                    {
                        if (Regex.IsMatch(withdrawal, @"^\d+.?\d{0,4}$"))
                        {
                            double withdrawalAmount = double.Parse(withdrawal);
                            this.account.Withdraw(withdrawalAmount);
                            this.StreamFormatSavings(DateTime.Now.ToString(), "-" + withdrawal, this.savingsAccount.SavingsTotal.ToString("C2"));
                            Console.WriteLine("\n\tYour withdrawal of $" + withdrawal + " is complete!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tOops! Please enter a valid integer only (can include a \".\" for cents).");
                            withdrawal = Console.ReadLine();
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\tOops! Choose an account you would like to withdraw funds from!");
                    Console.Write("\t");
                    input = Console.ReadLine();
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
