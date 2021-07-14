using System;
using System.Collections;

namespace Day7_2
{
    class MainProgram2
    {
        static void Main(string[] args)
        {
            Hashtable employeesTable = new Hashtable();
            Employees employees1 = new Employees(1, "kamal");
            Employees employees2 = new Employees(2, "hassan");
            Employees employees3 = new Employees(3, "nayagan");

            employeesTable.Add(employees1.EmployeeId, employees1);
            employeesTable.Add(employees2.EmployeeId, employees2);
            employeesTable.Add(employees3.EmployeeId, employees3);

            Employees data = (Employees)employeesTable[employees1.EmployeeId];
            //Console.WriteLine("Employee Id: {0} , Employee Name: {1}", employees1.EmployeeId, employees1.EmployeeName);

            foreach (Employees entry in employeesTable.Values)
            {
                Console.WriteLine("Employee id: {0}", entry.EmployeeId);
                Console.WriteLine("Employee name: {0}", entry.EmployeeName);

            }

        }
    }
}
