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
            Console.WriteLine("How many student information you want to enter");
            int n=int.Parse(Console.ReadLine());
           for(int i=1;i<=n;i++)
            {
                Console.WriteLine("Enter student id:");
                int stdid=int.Parse(Console.ReadLine());
                Console.WriteLine("enter student name:");
                string stdname=Console.ReadLine();
                Console.WriteLine("Enter student age:"); 
                int stdage=int.Parse(Console.ReadLine());
                student std=new student();
                std.stddetails(stdid, stdname, stdage);

            }


        }
    }
}
