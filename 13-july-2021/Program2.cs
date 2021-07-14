/*2. A program should have a class of Employees with property Id and Name .  Make use of indexers to create a collection semantics. */

using System;

namespace Day7_2
{
    class Employees
    {
        public Employees(int id, string name)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
        }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
}
