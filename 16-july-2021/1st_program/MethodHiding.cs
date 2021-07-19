using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_1
{
    class MethodHiding
    {
        readonly int someNumber = 10;
        public void WriteNum()
        {
            Console.WriteLine(someNumber);
        }
        public virtual void WriteString()
        {
            Console.WriteLine("Hi all!!!");
        }
    }
    class DerivedClass : MethodHiding
    {
        readonly int number = 5;
        public new void WriteNum()
        {
            Console.WriteLine(number);
        }
        public override void WriteString()
        {
            Console.WriteLine("Method from derived string.");
        }
    }
}
