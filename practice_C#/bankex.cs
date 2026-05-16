using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class bankex
    {
        private int balance;
        public void deposit(int amount)
        {
            balance =balance+ amount;
        }
        public void showbalance()
        {
            Console.WriteLine("your bank balance is :"+balance);
        }
    }
}
