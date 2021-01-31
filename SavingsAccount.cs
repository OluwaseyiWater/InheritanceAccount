
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAccount
{
   public class SavingsAccount : Account
    {
        private decimal _interestRate;


        public SavingsAccount(string fname, string lname, string bvn, decimal balance, decimal interestRate) : base(fname,lname,bvn, balance)
        {
            _interestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value > 0)
                    _interestRate = value;
                else
                    throw new Exception("Interest rate must be greater than zero");
            }
        }


        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}