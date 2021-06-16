using System;
using System.Collections.Generic;



namespace herpoli.Entities
{
     class SavingAccount : Account
    {
        
        public double InterestRate { get; set; }


        public SavingAccount(int number, string holder, double balance, double interestrate)
        : base(number, holder, balance)
        {


            InterestRate = interestrate;

        }

        public void UpdateBalance()
        {


            Balance += Balance * InterestRate;
        }


        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.00;


        }









    }
}
