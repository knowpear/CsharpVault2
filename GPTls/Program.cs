namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts[] arrayAccounts = new Accounts[19]; //we.類的批量創建方法
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
                        for (int i = 0; i < arrayAccounts.Length; i++)
                        {
                            arrayAccounts[i] = new Accounts();
                            arrayAccounts[i].balance = balance;
                            balance += 100;
                        }

                        Console.WriteLine("Accounts created successfully.");
                        break;
                    case 2:
                        Console.WriteLine("Enter account number:");
                        int accountNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter amount to withdraw:");
                        decimal amount = decimal.Parse(Console.ReadLine());

                        if (arrayAccounts[accountNumber].balance >= amount)
                        {
                            arrayAccounts[accountNumber].balance -= amount;
                            Console.WriteLine("Withdrawal successful.");
                            Console.WriteLine($"Current balance: {arrayAccounts[accountNumber].balance}");
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

    //public class Accounts
    //{
    //    public decimal balance { get; set; }
    //}
    //The Accounts class is necessary because it allows you to store and retrieve the balance of each account created in the bank system1.
    //Without this class, you would have no way of storing or retrieving this information.
    struct Accounts
    {
        public decimal balance;
    }
}
