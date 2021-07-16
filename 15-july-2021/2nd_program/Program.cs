namespace Day9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.GetLength();//public
            shape.Breadth();//private variable
            shape.DisplayPrivate();//private method
            shape.WidthMethod();//protected variable
            shape.DisplayProtected();//protected method
            shape.VolumeDisplay();//internal variable
            shape.VolumeDisplayMethod();//internal method
        }
    }
}
