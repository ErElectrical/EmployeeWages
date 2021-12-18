using System;
namespace employee
{
    public class Employee
    {
        static void Main(string[] args)
        {
            int emp_check = 1;
            Random r = new Random();    
            int outr = r.Next(0, 2);
            if ( outr == emp_check)
            {
                Console.WriteLine("employee prsent");
            }
            else
            {
                Console.WriteLine("employee not present");
            }
        }
    }
}

