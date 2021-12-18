using System;
namespace employee
{
    public class Employee
    {
        static void Main(string [] args)
        {
            var rem = new Employee_wages();
            int salary = rem.emp_wages("dinamite", 150, 22, 300);
            Console.WriteLine("your salary is ------ " + salary);

        }
    }
}
