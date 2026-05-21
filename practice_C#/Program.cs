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
            vehicle vn1 = new vehicle();
            vn1.displayvehicle();
            vehicle vn2 = new vehicle(1077, "mahindra", "XUV700");
            vn2.displayvehicle();
            vehicle vn3 = new vehicle(1011,"mahindra","XUV400");
            vn3.displayvehicle();
        }
    }
}
