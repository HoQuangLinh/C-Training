using EmployeeManagementSoftware;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("sksksk");

         Company company = new Company();
         Console.WriteLine(typeof(Company));
         //  company.AddEmployees();
         // Employee employee = new HR();
         //employee.AddInfo();
         //employee.GetInfo();
         

        Console.WriteLine("Phan mem quan ly nhan su cong ty");
        company.AddEmployees();
        company.GetEmployees();
        Console.WriteLine("Remove employee by name");
        

        Console.WriteLine("Total Leader is");
        Console.WriteLine(company.GetTotalLeader());

        Console.WriteLine("Total Hr is");
        Console.WriteLine(company.GetTotalHR());

        Console.WriteLine("Total members is");
        Console.WriteLine(company.GetTotalMember());

        Console.ReadKey();


    }
}
