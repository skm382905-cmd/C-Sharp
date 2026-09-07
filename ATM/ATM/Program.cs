using System.Runtime.CompilerServices;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome to Banking Control Panel==========");
            decimal balance = 1000.00m;

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your current balance is: " + balance);
                        break;
                    case 2:
                        Console.Write("Enter the amount to deposit: ");
                        var deposit = Convert.ToDecimal(Console.ReadLine());

                        if (deposit <= 0)
                        {
                            Console.WriteLine("The value must be greater than zero.");
                        }
                        else
                        {
                            balance += deposit;
                            Console.WriteLine("Deposit successful. Your new balance is: " + balance);
                        }
                        break;
                    case 3:
                        Console.Write("Enter the amount to withdraw: ");
                        var withdraw = Convert.ToDecimal(Console.ReadLine());
                        if (withdraw <= 0)
                        {
                            Console.WriteLine("The value must be greater than zero.");
                        }
                        else if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient amount. Your current balance is: " + balance);
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine("Withdrawal successful. Your new balance is: " + balance);
                        }
                        break;
                    case 4:
                        exit = true;
                        Console.WriteLine("\n================= Thank you for using our ATM =================");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
