using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages.People
{
    public partial class EditEmployee
    {
        [Parameter] public int EmployeeId { get; set; }
        Employee Employee = new Employee() { FirstName = "Jan", LastName = "Nowak", DateOfBirth = DateTime.Parse("1980-01-01"), DepartmentId=1, Id=1 };

        private void Edit()
        {

            Console.WriteLine("Editing the Employee...");
        }

    }
}
