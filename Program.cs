using System;
using herpoli.Entities;


namespace herpoli
{
    class Program
    {
        static void Main(string[] args)
        {
           Account acc = new Account(1001,"Alez",0.0);
           BusinessAccount bacc = new BusinessAccount(1002,"maria",0.0,500.00);

           Account acc1 = bacc;
          Account acc2 = new BusinessAccount(1003,"jairo",0.0,200.00);

          Account acc3 = new SavingAccount(1004,"ana",0.0,0.01);


          //BusinessAccount add1 = (BusinessAccount)new Account(1001,"alvarez",0.0);
          //add1.Loan(100.00);
          

          if(acc3 is BusinessAccount){
          
          BusinessAccount add2 = acc3 as BusinessAccount;
          add2.Loan(200.00);
          System.Console.WriteLine("Loan!");

          }

          if(acc3 is SavingAccount){


              SavingAccount add2 = acc3 as SavingAccount;
              add2.UpdateBalance();
              System.Console.WriteLine("UpBalance!");
          }


            Account acc6 =  new Account(1004, "ana", 500.0);
            Account acc7 = new SavingAccount(1004, "ana", 500.0, 0.01);


          acc6.Withdraw(10.0);
          acc7.Withdraw(10.0);
          System.Console.WriteLine(acc6.Balance);
          System.Console.WriteLine(acc7.Balance);




           

        }
    }
}
