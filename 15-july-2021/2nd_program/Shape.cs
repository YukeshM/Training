using System;
namespace Day9_2
{
    class Shape
    {
        public int Length = 5;
        private int _breadth = 10;
        protected int Width = 15;
        internal int Volume = 20;
        // public
        public void GetLength()
        {
            Console.WriteLine("From public variable: " + Length);
        }


        // for private
        public int breadth
        {
            get
            {
                return _breadth;
            }
        }
        public void Breadth()
        {
            Console.WriteLine("From private variable: " + _breadth);
        }
        private void DisplayBreadth()
        {
            Console.WriteLine("From private method. ");
        }
        public void DisplayPrivate()
        {
            DisplayBreadth();
        }


        //for protected
        public int WidthVariable
        {
            get { return Width; }
        }
        public void WidthMethod()
        {
            Console.WriteLine("From protected: " + Width);
        }
        protected void WidthProtected()
        {
            Console.WriteLine("From Protected method.");
        }
        public void DisplayProtected()
        {
            WidthProtected();
        }
        //internal
        public int VolumeVariable
        {
            get { return Volume; }
        }
        public void VolumeDisplay()
        {
            Console.WriteLine($"From internal variable: {Volume}");
        }
        internal void VolumeMethod()
        {
            Console.WriteLine("From internal method.");
        }
        public void VolumeDisplayMethod()
        {
            VolumeMethod();
        }

    }

}

