using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class internall
    {
        internal int a;
        public internall()
        {
            a = 100;
        }
        public void displayinternal()
        {
            Console.WriteLine("the value of a is :" + a);
        }
    }
    internal class internall2
    {
        public void displayinternal2()
        {
            internall in1 = new internall();
            Console.WriteLine("the value of a under internall 2 is :" + in1.a);
        }
    }
   
}
