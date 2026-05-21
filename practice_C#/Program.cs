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

            Console.WriteLine("Enter customer id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter customer name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter customer department name :");
            string dept = Console.ReadLine();

            thiskeyword nw = new thiskeyword(id, name, dept);
            nw.custdisplay();


        }
    }
}
