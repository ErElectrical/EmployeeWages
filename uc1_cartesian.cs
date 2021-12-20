using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartesian_program
{
    public static  class uc1
    {
        public static void line(int x1,int y1,int x2,int y2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length of line is --- " + length);

        }
    }
}
