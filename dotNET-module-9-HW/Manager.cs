using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_9_HW
{
    public class Manager : Employee
    {
        public double bonus { get; set; }

        public Manager (string name, int age, decimal salary, double bonus) 
            : base(name,age,salary)
        {
            this.bonus = bonus;
        }
        public override void CalculateAnnualSalary()
        {
            if (bonus != 0)
            {
                Console.WriteLine($"with bonus {bonus}, - " +(salary * 12 * (decimal)bonus));
            }
            else
            {
                Console.WriteLine("Годовая зп: " + salary * 12);
            }
            
        }
    }
}
