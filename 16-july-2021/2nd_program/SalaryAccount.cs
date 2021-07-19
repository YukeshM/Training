//Create a base class SalaryAccount , when creating the account you must pass the fields like account Id, Name , Balance
//Create a derived class DematAccount, when creating a demat account you must and should pass the Pan Card number. 
//Try using the Regular expressions which you learnt in self learning to validate the pan card number  format. 
//User should be able to create 
//- SalaryAccount alone
//-  Salary Account along with the DematAccount 


using System;


namespace Day10_2
{
    public class SalaryAccount
    {
        private string _AccountId;
        private string _AccountHolderName;
        private decimal _AccountBalance;

        public SalaryAccount(string accountId, string accountHolderName, decimal accountBalance)
        {
            this._AccountId = accountId;
            this._AccountHolderName = accountHolderName;
            this._AccountBalance = accountBalance;
        }



        public string AccountId
        {
            get { return this._AccountId; }
            set { this._AccountId = value; }
        }
        public string AccountHolderName
        {
            get { return this._AccountHolderName; }
            set { this._AccountHolderName = value; }
        }
        public decimal BankBalance
        {
            get { return this._AccountBalance; }
            set { this._AccountBalance = value; }
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
