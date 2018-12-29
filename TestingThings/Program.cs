using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace TestingThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Entities.Lists.EmployeesList empList = new Entities.Lists.EmployeesList();
            empList.loadFromDb();
            foreach(Employees emp in empList.List)
            {
                Console.Out.WriteLine(emp.ToString());
            }
            Console.In.Read();
        }
    }
}
