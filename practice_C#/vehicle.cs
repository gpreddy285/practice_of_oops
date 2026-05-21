using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class vehicle
    {
            public int vehicleno;
            public string vehiclename;
            public string vehiclemodel;
            public vehicle()
            {
                vehicleno = 1677;
                vehiclename = "mahindra";
                vehiclemodel = "thar";
            }
            public vehicle(int vehicleno, string vehiclename, string vehiclemodel)
            {
                this.vehicleno = vehicleno;
                this.vehiclename = vehiclename;
                this.vehiclemodel = vehiclemodel;
            }
        public vehicle(string vehiclename,string vehiclemodel)
        {
            this.vehiclename= vehiclename;
            this.vehiclemodel= vehiclemodel;
        }
            public void displayvehicle()
            {
                Console.WriteLine("Vehicle number is :" + vehicleno);
                Console.WriteLine("Vehicle name is  :" + vehiclename);
                Console.WriteLine("Vehicle model is :" + vehiclemodel);
            }
        

    }
}
