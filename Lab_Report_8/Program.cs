using System;

namespace BankingSystem
{
    class Program
    {
        static void Main()
        {
            double balance = 0;
            int choice = 0;

            while (true) // iteration statement
            {
                Console.WriteLine("\n--- Banking Menu ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue; // jump statement
                }

                switch (choice) // selection statement
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());

                        if (deposit > 0) // selection (if)
                        {
                            balance += deposit;
                            Console.WriteLine("Deposit successful.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());

                        if (withdraw > 0 && withdraw <= balance)
                        {
                            balance -= withdraw;
                            Console.WriteLine("Withdrawal successful.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance or invalid amount.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Current Balance: " + balance);
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        break; // jump statement

                    default:
                        Console.WriteLine("Invalid choice.");
                        continue; // jump statement
                }

                if (choice == 4)
                    break; // exit loop
            }
        }
    }
}