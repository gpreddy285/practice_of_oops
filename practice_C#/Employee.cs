using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class Employee
    {
            int EmployeeId;
            string EmployeeName;
            double salary;
            static string companyname = "Berkshaire HathWay Company";
            //public void EmployeeDetails()
            //{
            //    Console.WriteLine("Enter employee id :");
            //    EmployeeId = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter employee name :");
            //    EmployeeName = Console.ReadLine();
            //    Console.WriteLine("Enter Employee salary :");
            //    salary = int.Parse(Console.ReadLine());
            //}
        public Employee()
        {
            EmployeeId = 1;
            EmployeeName = "prasad";
            salary = 100000;
        }
            public void DisplayEmployeeDetails()
            {
                Console.WriteLine("Employee id is :" + EmployeeId);
                Console.WriteLine("Employee name is :" + EmployeeName);
                Console.WriteLine("Company Name is :" + companyname);
               Console.WriteLine("Employee salary is :" + salary);
            }
        public double salaryhike()
        {
            double salaryhike = (salary * 0.1);
            return salaryhike;
        }
        
        }
}
