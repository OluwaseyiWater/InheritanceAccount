using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAccount
{
   public class Account
    {
        private string _firstName;
        private string _lastName;
        private string _bvnNumber;
        private decimal _balance;

        

        //constructor that receives the instance variables with a public property
        public Account(string firstName,string lastName, string bvnNumber, decimal balance)
        {
            _firstName = firstName;
            _lastName = lastName;
            _bvnNumber = bvnNumber;
            _balance = balance;
        }


        
        
        
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName =value; }
        }

        
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        
        public string BvnNumber
        {
            get { return _bvnNumber; }
            set { _bvnNumber = value; }
        }


        public Account(decimal balance)
        {

        }
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
                else
                    throw new Exception("Balance cannot be negative");
            }
        }
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                throw new Exception("Credited amount must be greater than zero");
        }

        public virtual bool Debit(decimal amount)
        {
            bool OK;
            if (Balance >= amount)
            {
                Balance -= amount;
                OK = true;

            }
            else
            {
                Console.Write("Debit amount exceeded account balance.");
                OK = false;
            }
            return OK;
        }

    }
}