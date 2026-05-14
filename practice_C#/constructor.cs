using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    public class constructor
    {
        
            int a;
            int b;
            //public constructor()
            //{
            //    a = 10;
            //    b = 20;
            //    Console.WriteLine("Constructor is called");
            //}
            public void greet()
            {
                Console.WriteLine("value of a is :" + a);
                Console.WriteLine("value of b is :" + b);
                Console.WriteLine("Hello World");
            }
            public int greet2()
            {
                return a + b;
            }
        
        



    }
}
