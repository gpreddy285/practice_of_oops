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
            publicstudent ps1 = new publicstudent();
            ps1.publicdisplay();
            publicemp ps2 = new publicemp();
            ps2.empdetails();

        }
    }
}
