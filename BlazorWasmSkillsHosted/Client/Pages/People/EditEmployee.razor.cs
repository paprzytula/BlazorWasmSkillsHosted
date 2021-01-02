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
        [Parameter] public string FirstName { get; set; }
        [Parameter] public string LastName { get; set; }
    }
}
