using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class student_array
    {
        int sid;
        string name;
        int age;
        static string collegename = "imperial college";
        public void getdetails()
        {
            Console.WriteLine("Enter student id: ");
            sid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student name: ");
            name=Console.ReadLine();
            Console.WriteLine("Enter student age :");
            age=int.Parse(Console.ReadLine());
        }
        public static void displaycollege()
        {
            Console.WriteLine("College name is: " + collegename);
        }
        public void displaydetails()
        {
            Console.WriteLine("Student id is: " + sid);
            Console.WriteLine("Student name is :" + name);
            Console.WriteLine("Student age is :" + age);
        }
    }
}
