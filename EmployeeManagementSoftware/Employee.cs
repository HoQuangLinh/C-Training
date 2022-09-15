using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSoftware
{
    internal abstract class Employee
    { 
        //ID is unique
        public string Id { get; private set; }
        protected string Name { get; set; }
        protected int Old { get; set; }
        protected string Level { get; set; }
        protected string Gender { get; set; }
        protected int Salary { get; set; }

        

        public void EnterInfo()
        {
            Console.WriteLine("Id: ");
            Id = Console.ReadLine();
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Old: ");
            Old = int.Parse(Console.ReadLine());
            Console.WriteLine("Level: ");
            Level = Console.ReadLine();
            Console.WriteLine("Gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Salary: ");
            Salary= int.Parse(Console.ReadLine());
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Old} {Level} {Gender} {Salary} {GetJob()}");
        }
        public abstract string GetJob();
    }
}
