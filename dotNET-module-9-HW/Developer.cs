using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_9_HW
{
    public class Developer : Employee
    {
        public double LinesOfCodePerDay { get; set; }
        public Developer (string name, int age, decimal salary, double LinesOfCodePerDay) 
            : base(name, age, salary)
        {
            this.LinesOfCodePerDay = LinesOfCodePerDay;
        }

        public override void CalculateAnnualSalary()
        {
            if (LinesOfCodePerDay != 0)
            {
                Console.WriteLine($"ЗП с учетом написанного кода {LinesOfCodePerDay}, - " +(salary * 12 * (decimal)LinesOfCodePerDay));
            }
            else
            {
                Console.WriteLine("годовая зп: " + salary * 12);
            }
        }
    }
}
