using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_9_HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Olzhas", 21, 300000, 100);
            Developer developer = new Developer("Alikhan", 20, 10000, 123);
            manager.CalculateAnnualSalary();
            developer.CalculateAnnualSalary();

        }
    }
}
