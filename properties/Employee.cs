using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    public class Employee
    {
       int id;
        string name;
        int age;
        public void  setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
    }
}
