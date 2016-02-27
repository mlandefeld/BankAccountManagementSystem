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

        public Client()
        {
            this.firstName = "Margaret";
            this.lastName = "Landefeld";
            this.createdAt = DateTime.Now;
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
        
    }
}
