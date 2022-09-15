using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSoftware
{
    internal class Leader: Employee
    {
            public override string GetJob()
            {
                return "Review code and manage team";
            }
    }
}
