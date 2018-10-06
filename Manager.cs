using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceDemo1
{
    public class Manager : Employee
    {
        public Manager()
        {
            Console.WriteLine("Manager Class Default Constructor");
        }

        public Manager(int id, string name, double sal, double comp)
        {
            Console.WriteLine("Manager Class Parameterized Constructor");
        }
    }
}
