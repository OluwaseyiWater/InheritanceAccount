using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAccount
{
    class CheckingAccount : Account

    {
        private decimal _fee;

        public CheckingAccount(decimal balance, decimal fee) : base(balance)
        {
            _fee = fee;
        }
        public decimal Fee
        {
            get { return _fee; }
            set
            {
                if (value > 0)
                    _fee = value;
                else
                    throw new Exception("Fee cannot be less than zero");
            }
        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }

        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance -= Fee;
                return true;
            }
            return false;
        }
    }
}