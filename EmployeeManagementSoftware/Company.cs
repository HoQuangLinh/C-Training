using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSoftware
{
    internal class Company
    {
        private List<Employee> employees { get; set; }
        private int MemberCount { get; set; }
        public bool CheckExist(string id)
        {
            foreach (Employee employee in employees)
            {
                if(employee.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddEmployees()
        {
            Console.WriteLine("Please input number members");
            MemberCount = int.Parse(Console.ReadLine());
            employees = new List<Employee>();
            for (int i = 0; i < MemberCount; i++)
            {
                Console.WriteLine("Please chooose type employee");
                Console.WriteLine("1 is leader \n2 is HR \nanother is member");
                int typeEmployee = int.Parse(Console.ReadLine());
                Employee employee;
                switch (typeEmployee)
                {
                    case 1:
                        employee = new Leader();  
                        break;

                    case 2:
                        employee = new HR();        
                        break;
                    default:
                        employee = new Member();
                        break;

                }
                employee.EnterInfo();
                if (!CheckExist(employee.Id))
                {
                    
                    employees.Add(employee);
                }
                else
                {
                    Console.WriteLine($"Employee with  {employee.Id} has existed, please re-enter");
                }
                

            }
            

        }
        public void GetEmployees()
        {
           foreach (Employee employee in employees)
            {
                employee.GetInfo();
            }
        }
        public int GetTotalLeader()
        {
            int count = 0;
            employees.ForEach(employee =>
            {
                if(employee.GetType() == typeof(Leader))
                {
                    count++;
                }
            });
            return count;
        }
        public int GetTotalMember()
        {
            int count = 0;
            employees.ForEach(employee =>
            {
                if (employee.GetType() == typeof(Member))
                {
                    count++;
                }
            });
            return count;
        }
        public int GetTotalHR()
        {
            int count = 0;
            employees.ForEach(employee =>
            {
                if (employee.GetType() == typeof(HR))
                {
                    count++;
                }
            });
            return count;
        }
        public string RemoveEmployee(string id)
        {
            
            employees.Remove(employees.Where(e=>e.Id==id).First());
            return id;
        }

    }
}
