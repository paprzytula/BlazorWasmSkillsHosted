using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Shared.Entities
{
   public class DepartmentsEmployees
    {
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }
        public Department Department { get; set; }
        public Employee Employee { get; set; }
    }
}
