using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class Client
    {
        public string firstName;
        public DateTime createdAt;
        public string lastName;
        public List<Account> accounts;

        public Client()
        {
            this.firstName = "Margaret";
            this.lastName = "Landefeld";
            this.createdAt = DateTime.Now;
            Random rand = new Random();

            List<Account> accounts = new List<Account>();
            accounts.Add(new Accounts.Checking(rand));
            accounts.Add(new Accounts.Reserve(rand));
            accounts.Add(new Accounts.Savings(rand));

            this.accounts = accounts;
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public string Name()
        {
            return this.firstName + " " + this.lastName;
        }

        public DateTime CreatedAt
        {
            get { return this.createdAt; }
        }

        public List<Account> Accounts
        {
            get { return this.accounts; }
        }
        
    }
}
