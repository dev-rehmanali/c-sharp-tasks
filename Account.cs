using System;
using System.Collections.Generic;
using System.Text;

namespace Task3._2
{
    class Account
    {
        private decimal balance;
        private string name;
        
        public string Name 
        {

            get 
            {
                return name;
            }
        }

        public Account(string name, decimal balance) {

            this.name = name;
            this.balance = balance;
        }

        public bool Deposit(decimal amount) {

            if (amount <= 0)
            {

                return false;
            }
            else { 
            
                this.balance += amount;
                return true;
            }

        }//Deposit

        public bool Withdraw(decimal amount) {

            if (amount < 0 || amount > this.balance)
            {

                return false;
            }
            else {

                this.balance -= amount;
                return true;
            }

        }//Withdraw

        public void Print() {

            Console.WriteLine("Account Name is: " + this.name);
            Console.WriteLine("Account Balance is: " + this.balance);
        }


    }
}
