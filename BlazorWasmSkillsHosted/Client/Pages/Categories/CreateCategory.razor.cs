using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages.Categories
{
    public partial class CreateCategory
    {
        [Inject] NavigationManager NavigationManager { get; set; }
        private void SaveCategory()
        {
            Console.WriteLine(NavigationManager.Uri);
            NavigationManager.NavigateTo("category");
        }
    }
}
