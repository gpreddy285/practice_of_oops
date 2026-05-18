using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class studentconst
    {
       
            int sid;
            string sname;
            public studentconst()
            {
                sid = 1;
                sname = "prasad";
            }
            public studentconst(int sid)
            {
                sid = sid;
                sname = "not provided";
            }
            public studentconst(string sname)
            {
                
                sname = sname;
            }
            public studentconst(int sid, string sname)

            {
                sid = sid;
                sname = sname;
            }

            public void displaystudent()
            {
                Console.WriteLine("student id is :" + sid);
                Console.WriteLine("student name is :" + sname);
            }

        
    }  }
