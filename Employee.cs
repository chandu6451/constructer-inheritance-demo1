using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceDemo1
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Employee Class Default Constructor");
        }

        public Employee(int id, string name, double sal)
        {
            Console.WriteLine("Employee Class Parameterized Constructor");
        }
    }
}
