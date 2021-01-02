using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages.Categories
{
    public partial class DetailsCategory
    {
        [Parameter] public int CategoryId { get; set; }
        [Parameter] public string CategoryName { get; set; }
        protected override void OnInitialized()
        {
            Console.WriteLine($"The Id of Category is {CategoryId}");        
            Console.WriteLine($"The Name of Category is {CategoryName}");      
        }
    }
}
