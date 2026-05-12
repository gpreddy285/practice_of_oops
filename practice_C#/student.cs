using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class student
    {
        public static string collge_name = "Annapurna college";
        public void stddetails(int student_id,string studentname,int student_age)
        {
            Console.WriteLine("Student id is:"+student_id);
            Console.WriteLine("student name is :" + studentname);
            Console.WriteLine("student age is :" + student_age);
            Console.WriteLine("student college is :"+collge_name);
        }
    }
}
