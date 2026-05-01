using System;

namespace BankingSystem
{
    // BankAccount class to handle all banking operations
    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance = 0)
        {
            balance = initialBalance;
        }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Withdraw method with if-else selection
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrew ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        // Check Balance method
        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${balance}");
        }
    }

    // Main Program Class
    class Program
    {
        static void Main(string[] args)
        {
            // Create bank account with initial balance of $500
            BankAccount account = new BankAccount(500);
            bool exitProgram = false;

            Console.WriteLine("=== WELCOME TO BASIC BANKING SYSTEM ===");
            Console.WriteLine("=======================================");

            // Iteration: while loop keeps program running
            while (!exitProgram)
            {
                // Display menu
                Console.WriteLine("\n========== MAIN MENU ==========");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice (1-4): ");

                string input = Console.ReadLine();

                // Selection: switch statement for menu processing
                switch (input)
                {
                    case "1":  // Deposit
                        Console.Write("Enter amount to deposit: $");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            if (depositAmount > 0)
                                account.Deposit(depositAmount);
                            else
                                Console.WriteLine("Invalid amount. Please enter a positive number.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                        }
                        break;  // Jump: break exits the switch

                    case "2":  // Withdraw
                        Console.Write("Enter amount to withdraw: $");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            if (withdrawAmount > 0)
                                account.Withdraw(withdrawAmount);
                            else
                                Console.WriteLine("Invalid amount. Please enter a positive number.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                        }
                        break;  // Jump: break

                    case "3":  // Check Balance
                        account.CheckBalance();
                        break;  // Jump: break

                    case "4":  // Exit
                        Console.WriteLine("\nThank you for using our banking system!");
                        Console.WriteLine("Have a great day! Goodbye!");
                        exitProgram = true;
                        break;  // Jump: break

                    default:  // Invalid choice
                        Console.WriteLine("Invalid choice! Please enter 1, 2, 3, or 4.");
                        // Jump: continue - goes back to while loop condition
                        continue;
                }

                // Pause only if not exiting (using if selection)
                if (!exitProgram)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                    // No Console.Clear() - all previous outputs remain visible
                }
            }
        }
    }
}