using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day10_2
{
    public class DematAccount : SalaryAccount
    {

        private string _PanCard;
        public DematAccount(string accountId, string accountHolderName, decimal accountBalance ,string pan) : base(accountId, accountHolderName, accountBalance)
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
