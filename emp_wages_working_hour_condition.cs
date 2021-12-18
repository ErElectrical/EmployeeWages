using System;
namespace employee
{
    public class Employee
    {
        public const int emp_full_time = 1;
        public const int emp_part_time = 0;
        public const int emp_perhourrate = 200;
        public const int  max_work_hour_days=20;
        static void Main(string[] args)
        {
            int emp_wages = 0;
            int emp_hour = 0;
            for (int day=0;day<=max_work_hour_days;day++)
            {
                Random rem=new Random();
                int check = rem.Next(0, 3);
                switch(check)
                {
                    case emp_full_time:
                        emp_hour += 8;
                        Console.WriteLine("employee is present full time -- " + day);
                        break;
                    case emp_part_time:
                        emp_hour += 4;
                        Console.WriteLine("employee is present part time -- " + day);
                        break;
                    default:
                        emp_hour += 0;
                        Console.WriteLine("employee is on leave today ---- " + day);
                        break;
                }
            }
            emp_wages = emp_hour * emp_perhourrate;
            Console.WriteLine("your salary is --- " + emp_wages);

        }
    }
}
