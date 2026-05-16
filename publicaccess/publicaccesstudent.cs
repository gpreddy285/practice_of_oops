using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicaccess
{
    public class publicstudent
    {
        public int stdid = 1;
        public string stdname = "prasad";
        public int stdage = 27;
            public void publicdisplay()
            {
              Console.WriteLine("Student id is :"+stdid);
             Console.WriteLine("Student name is :"+stdname);
            Console.WriteLine("Student age is :" + stdage);
            }

        

    }
}
