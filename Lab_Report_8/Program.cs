using System;

namespace BankingSystem
{
    class Program
    {
        static void Main()
        {
            double balance = 0;
            int choice;

            // Iteration statement (while loop)
            while (true)
            {
                Console.WriteLine("\n===== BANK MENU =====");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                // Selection statement (switch)
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());

                        // Selection (if)
                        if (deposit <= 0)
                        {
                            Console.WriteLine("Invalid amount!");
                            continue; // Jump statement
                        }

                        balance += deposit;
                        Console.WriteLine("Amount deposited successfully.");
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
                        Console.WriteLine("Thank you for using the banking system.");
                        break; // Exit switch

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        continue;
                }

                // Exit condition
                if (choice == 4)
                {
                    break; // Jump statement to exit loop
                }
            }

            Console.WriteLine("Program terminated.");
            Console.ReadLine();
        }
    }
}
