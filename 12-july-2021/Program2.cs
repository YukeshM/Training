/*Write a program which works like a 3D graph moves. where the user enters x , y and z coordinates.
This program should take user inputs initialization using a constructor.  The program can have a Move() method to register the new location. Overload method using value types (int x, int y, intz) and also by passing the actual class instance (which has fields x,y  and z)*/

using System;

namespace Day6_2
{
    class CoOrdinates
    {
        public int x, y, z;
        public CoOrdinates(int xOrigin, int yOrigin, int zOrigin)
        {
            this.x = xOrigin;
            this.y = yOrigin;
            this.z = zOrigin;
        }
        public void Move(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
        public void Print(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the x-coordinate: ");
            int xCoOrdinate = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the y-coordinate: ");
            int yCoOrdinate = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the z-coordinate: ");
            int zCoOrdinate = int.Parse(Console.ReadLine());
            CoOrdinates coOrdinates = new CoOrdinates(xCoOrdinate, yCoOrdinate, zCoOrdinate);
            coOrdinates.Print(xCoOrdinate, yCoOrdinate, zCoOrdinate);
            coOrdinates.Move(xCoOrdinate, yCoOrdinate, zCoOrdinate);
        }
    }
}
