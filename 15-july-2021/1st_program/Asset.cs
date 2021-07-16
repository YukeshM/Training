using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_1
{
      abstract class  Asset
    {
        public abstract void Configuration();
        
        public  void Warranty()
        {
            Console.WriteLine("From warranty. ");
        }
    }
}
