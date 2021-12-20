using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartesian_program
{
    public static class uc2
    {
        public static void lineequal()
        {
            Console.WriteLine("enter end points with comma sepreation for both line");
            var line1=Console.ReadLine();
            var data = line1.Split(',');
            var x1=int.Parse(data[0]);
            var y1=int.Parse(data[1]);
            var x2=int.Parse(data[2]);
            var y2=int.Parse(data[3]);
            var x3=int.Parse(data[4]);
            var y3 =int.Parse(data[5]);
            var x4 = int.Parse(data[6]);
            var y4 = int.Parse(data[7]);
            var length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            var length2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            if (length1 == length2)
            {
                Console.WriteLine("lines are equal");
            }
            else
            {
                Console.WriteLine("lines are  not equal");

            }






        }
        
    }
}
