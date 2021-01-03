using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages.People
{
    public partial class EmployeeForm
    {
        [Parameter]  public Employee Employee { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        string imageUrl;

        protected override void OnInitialized()
        {
            if (!string.IsNullOrEmpty(Employee.Picture))
            {
                imageUrl = Employee.Picture;
                Employee.Picture = null;
            }
        }

        private void OnSelectedImage(string imageBase64)
        {
            Employee.Picture = imageBase64;
            imageUrl = null;
        }
    }
}
