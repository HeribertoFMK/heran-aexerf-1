namespace herpoli.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {

            Number = Number;
            Holder = holder;
            Balance = balance;

        }

        public virtual void Withdraw(double amount)
        {

            Balance -= amount + 5.0;


        }

        public void Deposit(double amount)
        {

            Balance += amount;

        }

    }
}
