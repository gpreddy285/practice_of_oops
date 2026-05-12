using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    
    internal class instance_method
    {
        public void add()
        {
            int a, b, c;
            a = 100;
            b = 150;
            c = a + b;
            Console.WriteLine("the sum of a and b is :" + c);
        }
        public static void subtraction()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a - b;
            Console.WriteLine("The subtraction of a and b is:" + c);
        }
    }
}
