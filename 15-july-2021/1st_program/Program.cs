namespace Day9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Configuration();
            computer.Warranty();
            Laptop laptop = new Laptop();
            laptop.Configuration();
            DockStation dockStation = new DockStation();
            dockStation.Configuration();
            Mouse mouse = new Mouse();
            mouse.Configuration();
            HeadPhone headPhone = new HeadPhone();
            headPhone.Configuration();
        }
    }
}
