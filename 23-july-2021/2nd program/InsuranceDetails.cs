using System;

namespace Day15_2
{
    public class InsuranceDetails
    {
        private int _InsuranceId;
        private DateTime _Validity;
        private int _CustomerId;
        private short _CustomerAge;

        public InsuranceDetails()
        {

        }
        public int InsuranceId
        {
            get { return _InsuranceId; }
            set { this._InsuranceId = value; }
        }
        public DateTime Time
        {
            get { return _Validity; }
            set { this._Validity = value; }
        }
        public int CustomerId
        {
            get { return _CustomerId; }
            set { this._CustomerId = value; }
        }
        public short Age
        {
            get { return _CustomerAge; }
            set { this._CustomerAge = value; }
        }

    }
}
