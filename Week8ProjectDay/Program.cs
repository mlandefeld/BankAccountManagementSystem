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
                if (input.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                {
                    Commands.Exit();
                }
                else if (input == "1")
                {
                    Console.Clear();
                    string one = "Bank Account Management System \n\n\t\t\t     View Client Information:\n\t\t\t*********************************";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(one);
                    commandInterface.ViewClientInformation();
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
                    commandInterface.ViewAccountBalance();
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
                    commandInterface.DepositFunds();
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
                    commandInterface.WithdrawFunds();
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
                    Console.WriteLine("Oops! You need to enter a vaild menu number!");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
