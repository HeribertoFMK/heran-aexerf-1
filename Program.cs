
using Course.Entities;
using System.Collections.Generic;
using System.Globalization;



namespace herpoli
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Account> list = new List<Account>();

           list.Add(new SavingsAccount(1001,"maria",500.0,0.01));
           list.Add(new BusinessAccount(1002,"alex",500.0,400.00));
            list.Add(new SavingsAccount(1003, "bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "ana", 500.0, 500.00));

            double sum = 0.0;

            foreach(Account met in list){


              sum += met.Balance;
            }

            System.Console.WriteLine("total balance"  + sum.ToString("F2",CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {
               System.Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
}
