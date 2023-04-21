namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[19];
            decimal balance = 0;

            Console.WriteLine("Welcome to the Bank!");

            while (true)
            {
                Console.WriteLine("Enter 1 to create an account.");
                Console.WriteLine("Enter 2 to withdraw money from an account.");
                Console.WriteLine("Enter 3 to exit.");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < accounts.Length; i++)
                        {
                            accounts[i] = new Account(balance);
                            balance += 100;
                        }

                        Console.WriteLine("Accounts created successfully.");
                        break;
                    case 2:
                        Console.WriteLine("Enter account number:");
                        int accountNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter amount to withdraw:");
                        decimal amount = decimal.Parse(Console.ReadLine());

                        if (accounts[accountNumber].Balance >= amount)
                        {
                            accounts[accountNumber].Withdraw(amount);
                            Console.WriteLine("Withdrawal successful.");
                            Console.WriteLine($"Current balance: {accounts[accountNumber].Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }

                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }

    public class Account
    {
        public decimal Balance { get; private set; }

        public Account(decimal balance)
        {
            Balance = balance;
        }

        public void Withdraw(decimal amount) //這個amount可以是任意名稱變量
        {
            Balance -= amount;
        }
    }
}
