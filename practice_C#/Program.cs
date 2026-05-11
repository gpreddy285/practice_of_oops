using practice_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C
    { 
    class myclass
    {
        public void Greet()
        {
            Console.WriteLine("Hello, This is method with no parameters and no return type");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass mc = new myclass();
            mc.Greet();
            parametersandnoreturntype no=new parametersandnoreturntype();
            no.add(10, 20);
            no.greet(10);
        }
    }
}
