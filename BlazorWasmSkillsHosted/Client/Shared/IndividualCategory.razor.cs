using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Shared
{
    public partial class IndividualCategory
    {
        [Parameter] public Category Category { get; set; }
        [Parameter] public EventCallback<Category> DeleteCategory { get; set; }
        private string categoryUrl = String.Empty;

        protected override void OnInitialized()
        {
            categoryUrl = $"category/{Category.Id}/{Category.CategoryName.Replace(" ", "-")}";
        }
    }
}
