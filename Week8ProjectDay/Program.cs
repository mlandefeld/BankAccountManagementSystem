using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class Program
    {
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
            menu.Append("1.View Client Information\n\t");
            menu.Append("2.View Account Balance\n\t");
            menu.Append("3.Deposit Funds\n\t");
            menu.Append("4.Withdraw Funds\n\t");
            menu.Append("5.Exit");


            Commands commandInterface = new Commands();
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

                    Console.WriteLine("\tWhich account would you like to view?");
                    Console.Write("\t1.Checking Account\n\t2.Reserve Account\n\t3.Savings Account\n\t");
                    string newInput = Console.ReadLine();
                    while (true)
                    {
                        if (newInput == "1")
                        {
                            commandInterface.ViewClientInformation("Checking");
                            break;
                        }
                        else if (newInput == "2")
                        {
                            commandInterface.ViewClientInformation("Reserve");
                            break;
                        }
                        else if (newInput == "3")
                        {
                            commandInterface.ViewClientInformation("Savings");
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
                else if (input == "2")
                {
                    Console.Clear();
                    string two = "Bank Account Management System \n\n\t\t\t     View Account Balance:\n\t\t\t******************************";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(two);

                    Console.WriteLine("\tWhich account would you like to view?");
                    Console.Write("\t1.Checking Account\n\t2.Reserve Account\n\t3.Savings Account\n\t");
                    string newInput = Console.ReadLine();
                    while (true)
                    {
                        if (newInput == "1")
                        {
                            commandInterface.ViewAccountBalance("Checking");
                            break;
                        }
                        else if (newInput == "2")
                        {
                            commandInterface.ViewAccountBalance("Reserve");
                            break;
                        }
                        else if (newInput == "3")
                        {
                            commandInterface.ViewAccountBalance("Savings");
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
                else if (input == "3")
                {
                    Console.Clear();
                    string three = "Bank Account Management System \n\n\t\t\t     Deposit Funds:\n\t\t\t************************";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(three);

                    Console.WriteLine("\tWhich account would you like to view?");
                    Console.Write("\t1.Checking Account\n\t2.Reserve Account\n\t3.Savings Account\n\t");
                    string newInput = Console.ReadLine();
                    while (true)
                    {
                        if (newInput == "1")
                        {
                            commandInterface.DepositFunds("Checking");
                            break;
                        }
                        else if (newInput == "2")
                        {
                            commandInterface.DepositFunds("Reserve");
                            break;
                        }
                        else if (newInput == "3")
                        {
                            commandInterface.DepositFunds("Savings");
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
                else if (input == "4")
                {
                    Console.Clear();
                    string four = "Bank Account Management System \n\n\t\t\t     Withdraw Funds:\n\t\t\t************************";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(four);

                    Console.WriteLine("\tWhich account would you like to view?");
                    Console.Write("\t1.Checking Account\n\t2.Reserve Account\n\t3.Savings Account\n\t");
                    string newInput = Console.ReadLine();
                    while (true)
                    {
                        if (newInput == "1")
                        {
                            commandInterface.WithdrawFunds("Checking");
                            break;
                        }
                        else if (newInput == "2")
                        {
                            commandInterface.WithdrawFunds("Reserve");
                            break;
                        }
                        else if (newInput == "3")
                        {
                            commandInterface.WithdrawFunds("Savings");
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
                else if (input == "5")
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