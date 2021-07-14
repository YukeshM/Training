/*1.Design an Employee class with properties EmployeeId, Name, Designation. Have an encapsulated field called Salary. Expose method called GetSalary() which displays or returns the current salary, but setting of salary should be done at the time of hiring (object creation time).  Have an encapsulated method called IncreasePay() , where the salary can be increased by 10%. The user / client  should be exposed only to a method called Promote() with a boolean value, which decides the Increase Pay of 10% or not.*/
using System;
using System.Reflection;

namespace Day7_1
{
    class EmployeeDetails
    {
        public EmployeeDetails(int id, string name, string designation, double salary)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.Designation = designation;
            this.InitialSalary = salary;
        }
        public int EmployeeId
        {
            get;
            set;
        }
        public string EmployeeName
        {
            get;
            set;
        }
        public string Designation
        {
            get;
            set;
        }
        private double Salary;
        public double InitialSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }


        public void GetSalary()
        {
            Console.WriteLine("current salary: {0}", Salary);
        }
        private void IncreasePay()
        {
            double increasePay = (InitialSalary * 0.1) + InitialSalary;
            Console.WriteLine("Increased salary: {0}", increasePay);
        }
        public void IncreaseSalary()
        {
            //get { return increasePay; }
            //set { increasePay = Value; }
        }
        public void Promote(bool result)
        {
            if (true)
            {
                //IncreaseSalary();
                typeof(EmployeeDetails).GetMethod("IncreasePay", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new EmployeeDetails(), null);
            }
            else
            {
                Console.WriteLine(" ");
            }

        }


    }
}
