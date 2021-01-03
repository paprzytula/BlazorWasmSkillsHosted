using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Shared.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int DepartmentId { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
        public string Picture { get; set; }

    }
}
