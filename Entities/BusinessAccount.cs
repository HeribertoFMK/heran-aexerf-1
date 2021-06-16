namespace herpoli.Entities
{
    public class BusinessAccount : Account
    {
        public double LoadLimit{get;set;}

        public BusinessAccount(int number, string holder, double balance, double loadlimit):base(number,holder,balance){


            LoadLimit = loadlimit;

        }

        public void Loan(double amount){

            if(amount > LoadLimit){


                Balance += amount;

            }



        }

        
    }
    
}
