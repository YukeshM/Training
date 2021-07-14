namespace Day7_1
{
    class Emloyee
    {
        static void Main(string[] args)
        {
            EmployeeDetails newEmployee = new EmployeeDetails(4, "yukesh", "trainee", 1000);
            newEmployee.GetSalary();
            newEmployee.Promote(true);

        }


    }
}
