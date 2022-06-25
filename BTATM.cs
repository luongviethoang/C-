using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btClassOffLine
{
    internal class BTATM
    {static void Main()
        {
            Console.Write("User name: ");
            String UserName = Convert.ToString(Console.ReadLine());
            Console.Write("Password: ");
            String Password = Convert.ToString(Console.ReadLine());
            if (Password.Length != 6)
            {
                Console.WriteLine("Your password must have 6 numbers! ");
                return;
            };
            int choice = 0;
            double accountBalance = 100000000000;
            do
            {
                Console.WriteLine("please choose from 1 to 4:");
                Console.WriteLine("1. Transfer");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Show balance");
                Console.WriteLine("4. Exit");
                String input = Console.ReadLine();
                choice = Convert.ToInt32(input);
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the Bank number: ");                  
                        string BankNumber = Convert.ToString(Console.ReadLine());
                        if (BankNumber.Length > 9)
                        {
                            Console.WriteLine("Account number you want to transfer money must be greater than 9 numbers! ");
                            continue;
                        };
                        Console.Write("Enter the bank name: ");
                        string BankName = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter the amount you want to transfer: ");
                        double Moneytransfer = Convert.ToDouble(Console.ReadLine());
                        if (Moneytransfer > 200000000)
                        {
                            Console.WriteLine("money transfer limit is 20 million VND! ");
                            continue;
                        };
                        Console.WriteLine($"You have successfully transferred the money");
                        Console.WriteLine($"Your remaining balance is: {1.0*accountBalance - Moneytransfer} VND");
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount you want to withdraw");
                        int withdrawMoney = Convert.ToInt32(Console.ReadLine());
                        if (withdrawMoney > 200000000)
                        {
                            Console.WriteLine("money withdraw limit is 20 million VND! ");
                            continue;
                        };
                        Console.WriteLine($"You withdrew: {withdrawMoney} VND. Your remaining balance is: {accountBalance - withdrawMoney} ");
                        break;
                    case 3:
                        Console.WriteLine($"Your Balance is: {accountBalance} ");
                        break;
                    default:
                        Console.WriteLine("Enter the Number from 1 to 4 ");
                        break;
                }

            } while (choice != 4) ;
            Console.WriteLine("see you again! ^^ ");
        }
    }
}
