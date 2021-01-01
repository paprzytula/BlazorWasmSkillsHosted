using BlazorWasmSkillsHosted.Client.Helpers;
using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages
{
    public partial class Index
    {
        [Inject]  IRepository Repository {get; set;}
        private List<Category> categories;
        protected async override Task OnInitializedAsync()
        {
            categories = Repository.GetCategories();
        }
    }
}
