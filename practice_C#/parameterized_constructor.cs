using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class parameterized_constructor
    {
        int custid;
        string cust_name;
        float cust_expenditure;
        public parameterized_constructor(int custid,string cust_name,float cust_expenditure)
        {
            this.custid = custid;
            this.cust_name = cust_name;
            this.cust_expenditure = cust_expenditure;
        }
        public void custdisplay()
        {
            Console.WriteLine("Customer id is :"+custid);
            Console.WriteLine("Customer name is :" + cust_name);
            Console.WriteLine("Customer expenditure is :" + cust_expenditure);
        }
    }
}
