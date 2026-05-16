using practice_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using publicaccess;
using publicaccessemployee;

namespace practice_C
{ 
    
    internal class Program
    {
        static void Main(string[] args)
        {
           bankex be = new bankex();
            be.deposit(10000);
            be.showbalance();

        }
    }
}
