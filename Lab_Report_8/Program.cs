using System;

namespace SimpleBankSystem
{
    class BankApp
    {
        static void Main()
        {
            double balance = 1000; 
            int choice;

            while (true) 
            {
                
                Console.WriteLine("Neha's Banking System");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                // selection using switch
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());

                        if (deposit <= 0)
                        {
                            Console.WriteLine("Invalid amount!");
                            continue; // jump statement
                        }

                        balance += deposit;
                        Console.WriteLine("Deposit successful!");
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
                            Console.WriteLine("Withdrawal successful!");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Current Balance: " + balance);
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using the banking system!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        continue;
                }

                if (choice == 4)
                    break; // exit loop
            }
        }
    }
}