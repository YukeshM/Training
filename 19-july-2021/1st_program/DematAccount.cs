using System;
using System.Text.RegularExpressions;

namespace Day11_1
{

    public class DematAccount : SalaryAccount
    {

        private string _PanCard;

        public void AvailFreeCreditScoreCheck()
        {
            Console.WriteLine("From avail free credit score check");
        }
        public void GetDailyStockUpdates()
        {
            Console.WriteLine("From get daily stock updates");
        }
        public DematAccount(string accountId, string accountHolderName, decimal accountBalance, string pan) : base(accountId, accountHolderName, accountBalance)
        {

            this._PanCard = pan;
        }
        public string validatePan()
        {
            Regex regex = new Regex(@"[A-Z]{5}[0-9]{4}[A-Z]{1}");
            return regex.IsMatch(_PanCard) ? "Valid" : "Not valid";
        }
        public void getSalaryWithDemat()
        {
            base.GetSalary();
            Console.WriteLine("Your PAN ID is: {0}", validatePan());
        }

    }
}
