using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSoftware
{
    internal class HR : Employee
    {
        public override string GetJob()
        {
            return "Do the paper work and calculate salary of all employee";
        }
    }
}
