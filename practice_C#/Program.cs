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
            //Console.WriteLine("How many students information you want to enter");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Enter student id:");
            //    int stdid = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter student name:");
            //    string stdname = Console.ReadLine();
            //    Console.WriteLine("Enter student age:");
            //    int stdage = int.Parse(Console.ReadLine());
            //    student std = new student();
            //    std.stddetails(stdid, stdname, stdage);
            //}
            //student_array[] student = new student_array[3];
            //for(int i=0;i<student.Length;i++)
            //{
            //    student[i] = new student_array();
            //    student[i].getdetails();
            //}
            //for(int i=0;i<student.Length;i++)
            //{
            //    student[i].displaydetails();
            //    student_array.displaycollege();
            //}

            //Employee[] emp = new Employee[3];
            // for (int i = 0; i < emp.Length; i++)
            // {
            //     emp[i] = new Employee();
            //     emp[i].EmployeeDetails();
            // }
            // for (int i = 0; i <emp.Length; i++)
            // {
            //     emp[i].DisplayEmployeeDetails();
            // }
            //Employee salemp=new Employee();
            // salemp.DisplayEmployeeDetails();
            // double hike=salemp.salaryhike();
            // Console.WriteLine("salary hike for your salary :"+hike);

            // //constructor my = new constructor();
            //my.greet();
            //int greet2res = my.greet2();
            //Console.WriteLine(" Greet 2 result is :" + greet2res);
            //    parameterized_constructor pc = new parameterized_constructor(007,"anil",134000);
            //    pc.custdisplay();
            //    parameterized_constructor pc1 = new parameterized_constructor(8, "sandy", 120000);
            //    pc1.custdisplay();

            //passing connection via parameterized constructor
            //string connstring = "Server=.;InitialCatalog=practicedb;Integrated Security=True;";
            //dbconnection db=new dbconnection(connstring);
            //db.openconnection();
            //db.closeconnection();

            carexample ce = new carexample("white", "bugado", 2022);
            ce.cardisplay();
            carexample ce1 = new carexample("black", "ford", 1799);
            ce1.cardisplay();

        }
    }
}
