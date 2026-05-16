using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicaccessemployee
{
    public class publicemp
    {
        public int empid=111;
        public string empname="kumar";
        public int empsalary=100000;
        public void empdetails()
        {
            Console.WriteLine("Employee id is :"+empid);
            Console.WriteLine("Employee name is :"+empname);
            Console.WriteLine("Employee salary is :" + empsalary);
        }
    }
}
