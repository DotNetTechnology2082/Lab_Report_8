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
                Console.WriteLine("\n--- Banking System Menu ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());

                        if (deposit <= 0)
                        {
                            Console.WriteLine("Invalid amount!");
                            continue; // Jump statement
                        }

                        balance += deposit;
                        Console.WriteLine("Amount Deposited Successfully.");
                        break;

                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());

                        if (withdraw <= 0)
                        {
                            Console.WriteLine("Invalid amount!");
                            continue;
                        }

                        if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient balance!");
                            // We use else if when:

                            // only one condition should execute from a chain
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine("Withdrawal Successful.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Current Balance = " + balance);
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        break; // exit switch

                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;
                }

                if (choice == 4)
                    break; // exit loop
            }
        }
    }
}