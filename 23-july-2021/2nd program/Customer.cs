namespace Day15_2
{
    class Customer
    {
        private int _CustomerID;
        private string _CustomerName;
        private short _CustomerAge;
        private string _CustomerBloodGroup;


        public Customer(int id, string name, short age, string bloodGroup)
        {
            this._CustomerID = id;
            this._CustomerName = name;
            this._CustomerAge = age;
            this._CustomerBloodGroup = bloodGroup;
        }
        public int CustomerId
        {
            get { return _CustomerID; }
            set { this._CustomerID = value; }
        }
        public string CustomerName
        {
            get { return _CustomerName; }
            set { this._CustomerName = value; }
        }

        public short CustomerAge
        {
            get { return _CustomerAge; }
            set { this._CustomerAge = value; }
        }
        public string CustomerBloodGroup
        {
            get { return _CustomerBloodGroup; }
            set { this._CustomerBloodGroup = value; }
        }



    }
}
