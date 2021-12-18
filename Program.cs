using System;
namespace employee
{
    public class compute_employee_wages_company
    {
        public const int emp_full_time = 1;
        public const int emp_part_time = 0;
        private string company_name;
        private int emp_rate_per_hour;
        private int emp_max_working_days;
        private int emp_max_working_hour;
        public compute_employee_wages_company(string company_name,int emp_rate_per_hour,int emp_max_working_days,int emp_max_working_hour)
        {
            // we create a constructor for our class so that we can initialsed value for our varible.
            // we can declare our varible as public too but to understand the use of this keyword we provide them private access modifier
            // this keyword is use in mainly three situation in c#
            // to refer current instance of a class.
            // to differentiate between method parameter and feilds of the class if they have same name which is case here
            // to call other constructor in same class.
            this.company_name = company_name;
            this.emp_rate_per_hour = emp_rate_per_hour;
            this.emp_max_working_days = emp_max_working_days;
            this.emp_max_working_hour = emp_max_working_hour;
            // initialize the varible their value which is provided by user.
        public string emp_wages( )
            {
                int emp_hours = 0;
                int emp_wages = 0;
                int emp_working_days = 0;
                while(emp_hours <= this.emp_max_working_hour || emp_max_working_days <= this.emp_max_working_days )
                {
                    emp_working_days++;
                    Random rem = new Random();
                    int check = rem.Next(0, 3);
                    switch(check)
                    {
                        case emp_full_time:
                            emp_hours += 8;
                            Console.WriteLine("you are on full time role on day --- " + emp_working_days);
                            break;
                        case emp_part_time:
                            emp_hours += 4;
                            Console.WriteLine("you are on part time role on day --- " + emp_working_days);
                            break;
                        default:
                            Console.WriteLine("you are on leave   day --- " + emp_working_days);
                            break;





                    }
                }
                emp_wages = emp_hours * this.emp_rate_per_hour;
                return "your company is --  " + this.company_name + " employee wages is --  " + emp_wages;
            }
           

        }
    }
}
