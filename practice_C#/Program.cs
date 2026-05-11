using practice_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C
    { 
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
          void_and_parameterless less=new void_and_parameterless();
            less.Greet();
            void_and_parameterized no=new void_and_parameterized();
            no.add(10, 20);
            no.greet(10);
        }
    }
}
