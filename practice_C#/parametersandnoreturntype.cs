using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class parametersandnoreturntype
    {
        public void add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("The sum of a and b is:" + c);
        }
        public void greet(int x)
        {
            Console.WriteLine("the value of x is :" + x);
        }
    }
}
