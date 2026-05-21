using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practice_C_
{
    internal class thiskeyword
    {
       
            public int id;
            public string name;
            public string dept;

            public thiskeyword(int id, string name, string dept)
            {
                this.id = id;
                this.name = name;
                this.dept = dept;
            }
            public void custdisplay()
            {
            Console.WriteLine("Customer id is :"+id);
            Console.WriteLine("customer name is :" + name);
            Console.WriteLine("customer department is :" + dept);
             }
        
        

}
}
