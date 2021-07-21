using System;

namespace Day11_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter which type of account do you want to create, Enter 1 or 2: \n1.Salary Account Alone \n2.Salary Account with Demat Account ");
            int usertype = Convert.ToInt32(Console.ReadLine());
            string accountId;
            string accountHolderName;
            decimal accountBalance;
            switch (usertype)
            {
                case 1:
                    Console.WriteLine("Enter Acc No: ");
                    accountId = Console.ReadLine();
                    Console.WriteLine("Your Name:");
                    accountHolderName = Console.ReadLine();
                    Console.WriteLine("Your balance:");
                    accountBalance = Convert.ToDecimal(Console.ReadLine());
                    SalaryAccount salaryAccount = new SalaryAccount(accountId, accountHolderName, accountBalance);
                    salaryAccount.GetSalary();
                    salaryAccount.AvailFreeLockerMethod();
                    salaryAccount.AvailFreeDemandDraft();
                    break;
                case 2:
                    Console.WriteLine("Enter Acc No: ");
                    accountId = Console.ReadLine();
                    Console.WriteLine("Your Name:");
                    accountHolderName = Console.ReadLine();
                    Console.WriteLine("Your balance:");
                    accountBalance = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter Your PAN ID:");
                    string panCardNum = Console.ReadLine();
                    DematAccount dematAccount = new DematAccount(accountId, accountHolderName, accountBalance, panCardNum);
                    dematAccount.getSalaryWithDemat();
                    dematAccount.AvailFreeCreditScoreCheck();
                    dematAccount.GetDailyStockUpdates();
                    break;
                default:
                    Console.WriteLine("Sorry its an Invalid input");
                    break;
            }
        }
    }

}
