using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class carexample
    {
        
        string carcolor;
        string carmodel;
        int caryear;
        public carexample(string carcolor, string carmodel,int caryear)
            {
           this.carcolor = carcolor;   
            this.carmodel=carmodel;
            this.caryear = caryear;
        }
        public void  cardisplay()
        {
            Console.WriteLine("car color is :"+carcolor);
            Console.WriteLine("car model is :" + carmodel);
            if(caryear<1800)
            {
                Console.WriteLine("before 1800 cars are not made");
            }
            else
            {
                Console.WriteLine("car year is :" + caryear);
            }
        }

    }
}
