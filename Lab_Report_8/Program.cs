using System;

namespace BankingSystem
{
    class Program
    {
        static void Main()
        {
            double balance = 0;
            int choice;

            while (true)
            {
                Console.WriteLine("\n--- Banking Menu ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");

                // Safe input for choice
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter deposit amount: ");

                        if (!double.TryParse(Console.ReadLine(), out double deposit))
                        {
                            Console.WriteLine("Invalid amount!");
                            continue;
                        }

                        if (deposit <= 0)
                        {
                            Console.WriteLine("Amount must be greater than zero!");
                            continue;
                        }

                        balance += deposit;
                        Console.WriteLine("\nAmount deposited successfully.");
                        break;

                    case 2:
                        Console.Write("Enter withdrawal amount: ");

                        if (!double.TryParse(Console.ReadLine(), out double withdraw))
                        {
                            Console.WriteLine("Invalid amount!");
                            continue;
                        }

                        if (withdraw <= 0)
                        {
                            Console.WriteLine("Amount must be greater than zero!");
                            continue;
                        }

                        if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient balance!");
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine("\nAmount withdrawn successfully.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Current Balance: " + balance.ToString("0.00"));
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        return; // clean exit

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}