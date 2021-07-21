using System;

namespace Day11_1
{
    

    public class SalaryAccount : IBenefits
    {
        private string _AccountId;
        private string _AccountHolderName;
        private decimal _AccountBalance;

        public void AvailFreeDemandDraft()
        {
   
            Console.WriteLine("From avail free demand draft method"); 

        }
        public void AvailFreeLockerMethod()
        {
            Console.WriteLine("From avail free locker method");
        }


        public SalaryAccount(string accountId, string accountHolderName, decimal accountBalance)
        {
            this._AccountId = accountId;
            this._AccountHolderName = accountHolderName;
            this._AccountBalance = accountBalance;
        }

        public void GetSalary()
        {
            if (_AccountId.Length < 16)
            {
                Console.WriteLine("Your account number is invalid");
            }
            else
            {
                Console.WriteLine($"your salary account detail...\nAcc No: {_AccountId}\nName:{_AccountHolderName}\nBalance:{_AccountBalance}");
            }
        }
    }
}
