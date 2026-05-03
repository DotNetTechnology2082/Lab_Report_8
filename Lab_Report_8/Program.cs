using System;

namespace BankingSystem
{
    class Program
    {
        static void Main()
        {
            double balance = 0;
            int choice;

            while (true) // iteration statement
            {
                Console.WriteLine("\n--- Banking Menu ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) // selection statement
                {
                    case 1:
                        Console.Write("Enter deposit amount: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());

                        if (deposit <= 0)
                        {
                            Console.WriteLine("Invalid amount!");
                            continue; // jump statement
                        }

                        balance += deposit;
                        Console.WriteLine("Amount deposited successfully.");
                        break;

                    case 2:
                        Console.Write("Enter withdrawal amount: ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());

                        if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient balance!");
                        }
                        else if (withdraw <= 0)
                        {
                            Console.WriteLine("Invalid amount!");
                            continue;
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine("Amount withdrawn successfully.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Current Balance: " + balance);
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        break; // exits switch

                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;
                }

                if (choice == 4)
                    break; // exits while loop
            }
        }
    }
}
