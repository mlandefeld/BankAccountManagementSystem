using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class Program
    {
        /*
        public Client client;
        public Accounts.Checking checking;
        public Accounts.Reserve reserve;
        public Accounts.Savings savings;

        public Program()
        {
            this.client = new Client();

            this.checking = new Accounts.Checking();
            this.reserve = new Accounts.Reserve();
            this.savings = new Accounts.Savings();
        }
        */
        static void Main(string[] args)
        {
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }

            Console.Title = "Bank Account Management System";
            string s = "Bank Account Management System";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);

            StringBuilder menu = new StringBuilder();
            menu.Append("\n\tMenu: Enter a number to select the corresponding option\n\t");
            menu.Append("1: View Client Information\n\t");
            menu.Append("   View Balance for:\n\t");
            menu.Append("2:----Checking Account\n\t");
            menu.Append("3:----Reserve Account\n\t");//short term savings
            menu.Append("4:----Savings Account\n\t");
            menu.Append("5: Deposit Funds\n\t");
            menu.Append("6: Withdraw Funds\n\t");
            menu.Append("7: Exit");


        Commands commandInterface = new Commands();
        Account account = new Account(); //temporary?
        Console.WriteLine(menu);
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "1")
                {
                    Console.Clear();
                    string one = "Bank Account Management System\n\n\t\t\t     View Client Information:\n\t\t\t*********************************";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(one);
                    commandInterface.ViewClientInformation(account);//problem with method. What do I need to pass in?
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;

                }
                else if (input == "2")
                {
                    Console.Clear();
                    string two = "Bank Account Management System \n\n\t\t\t     View Checking Account Balance:\n\t\t\t*********************************";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(two);
                    commandInterface.ViewAccountBalance(account);
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "3")
                {
                    Console.Clear();
                    string two = "Bank Account Management System \n\n\t\t\t     View Reserve Account Balance:\n\t\t\t*********************************";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(two);
                    commandInterface.ViewAccountBalance(account);
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "4")
                {
                    Console.Clear();
                    string two = "Bank Account Management System \n\n\t\t\t     View Savings Account Balance:\n\t\t\t*********************************";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(two);
                    commandInterface.ViewAccountBalance(account);
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "5")
                {
                    Console.Clear();
                    string three = "Bank Account Management System \n\n\t\t\t     Deposit Funds:\n\t\t\t************************";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(three);
                    Console.WriteLine("\tWhich account would you like to deposit funds into?");
                    Console.Write("\t1.Checking Account\n\t2.Reserve Account\n\t3.Savings Account\n\t");
                    string newInput = Console.ReadLine();
                    while (true)
                    {
                        if (newInput == "1")
                        {
                            commandInterface.DepositFunds(account);//program errors here and in deposit method. problem with streamwriter
                            break;
                        }
                        else if (newInput == "2")
                        {
                            commandInterface.DepositFunds(account);
                            break;
                        }
                        else if (newInput == "3")
                        {
                            commandInterface.DepositFunds(account);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tOops! Choose an account you would like to deposit funds into!");
                            Console.Write("\t");
                            newInput = Console.ReadLine();
                        }
                    }   
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "6")
                {
                    Console.Clear();
                    string four = "Bank Account Management System \n\n\t\t\t     Withdraw Funds:\n\t\t\t************************";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(four);
                    Console.WriteLine("\tWhich account would you like to deposit funds into?");
                    Console.Write("\t1.Checking Account\n\t2.Reserve Account\n\t3.Savings Account\n\t");
                    string newInput = Console.ReadLine();
                    while (true)
                    {
                        if (newInput == "1")
                        {
                            commandInterface.WithdrawFunds(account);
                            break;
                        }
                        else if (newInput == "2")
                        {
                            commandInterface.WithdrawFunds(account);
                            break;
                        }
                        else if (newInput == "3")
                        {
                            commandInterface.WithdrawFunds(account);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tOops! Choose an account you would like to deposit funds into!");
                            Console.Write("\t");
                            input = Console.ReadLine();
                        }
                    }
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "7")
                {
                    Commands.Exit();
                }
                else
                {
                    Console.WriteLine("Oops! Choose a valid menu number to continue!");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
