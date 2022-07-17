using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em =new Employee();
            em.setId(2021);
            Console.WriteLine("your id Employee is :");
            Console.WriteLine(em.getId());
            Console.ReadLine();
        }
    }
}
