using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    public class Employee_wages
    {
        const int emp_full_time = 0;
        const int emp_part_time = 1;
        public  int emp_wages(string name,int max_work_hour,int max_work_days,int emp_rate_perhour)
        {
            int emp_hour = 0;
            int emp_wages = 0;
            int working_days = 0;
            while(emp_hour <= max_work_hour || working_days <= max_work_days )
            {
                working_days++;
                Random rem=new Random();
                int check = rem.Next(0, 3);
                switch(check)
                {
                    case emp_full_time:
                        Console.WriteLine("employee is working as full time --- " + working_days);
                        emp_hour += 8;
                        break;
                    case emp_part_time:
                        Console.WriteLine("employee is working as part time -- " + working_days);
                        emp_hour += 4;
                        break;
                    default:
                        Console.WriteLine("you are on leave today" + working_days);
                        break;



                }

            }
            emp_wages = emp_hour * emp_rate_perhour;
            return emp_wages;

        }
    }
}
