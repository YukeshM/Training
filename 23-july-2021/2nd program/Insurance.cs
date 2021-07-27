using System;

namespace Day15_2
{
    public class MedicalInsurance : InsuranceDetails
    {
        private decimal _PremiumAmount;

        private int _Appointments;

        public MedicalInsurance(decimal premiumAmount, int appointment)
        {
            this._PremiumAmount = premiumAmount;
            this._Appointments = appointment;
        }
        public decimal PremiumAmount
        {
            get { return _PremiumAmount; }
            set { this._PremiumAmount = value; }
        }
        public int Appointments
        {
            get { return _Appointments; }
            set { this._Appointments = value; }
        }

    }
    public class LifeInsurance : InsuranceDetails
    {
        private decimal _PremiumAmount;
        private string _NomineeName;
        private DateTime _MaturityDate;

        public LifeInsurance(decimal premiumAmount, string nomineeName, DateTime maturityDate)
        {
            this._PremiumAmount = premiumAmount;
            this._NomineeName = nomineeName;
            this._MaturityDate = maturityDate;
        }
        public decimal PremiumAmount
        {
            get { return _PremiumAmount; }
            set { this._PremiumAmount = value; }
        }

        public string NomineeName
        {
            get { return _NomineeName; }
            set { this._NomineeName = value; }
        }
        public DateTime MaturityDate
        {
            get { return _MaturityDate; }
            set { this._MaturityDate = value; }
        }
    }
}
