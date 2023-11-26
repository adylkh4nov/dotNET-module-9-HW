using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_9_HW
{
    public class Employee
    {
        protected string name { get; set; }
        protected int age { get; set; }
        protected decimal salary { get; set; }
        protected Employee() : this("Неизвестно")
        {

        }
        protected Employee (string name) : this(name, 0)
        {

        }
        protected Employee (string name, int age) : this(name, age, 0)
        {

        }
        protected Employee (string name, int age, decimal salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        protected string GetInfo()
        {
            return $"Name: {name}\tAge: {age}\tSalary: {salary}\n";
        }
        public virtual void CalculateAnnualSalary()
        {
            Console.WriteLine(salary * 12);
        }
    }
}
