namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank System!");

            double balance = 0;

            while (true)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the amount to deposit: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        balance += depositAmount;
                        Console.WriteLine("Deposit successful. Your new balance is {0:C}.", balance);
                        break;

                    case 2:
                        Console.Write("Enter the amount to withdraw: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Withdrawal failed. Insufficient balance.");
                        }
                        else
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine("Withdrawal successful. Your new balance is {0:C}.", balance);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Your current balance is {0:C}.", balance);
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using the Bank System!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
