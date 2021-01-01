using BlazorWasmSkillsHosted.Client.Helpers;
using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Shared
{
    public partial class CategoriesList
    {
        Confirmation confirmation;
        [Inject] IJSRuntime JS {get;set;}
      [Parameter] public List<Category> Categories { get; set; }

        bool displayButtons = true;
        Category CategoryToBeDeleted;
        private async Task DeleteCategory(Category category)
        {
            CategoryToBeDeleted = category;
            confirmation.Show();
            //await JS.MyFunction("custom message");
            //var confirmed = await JS.Confirm($"Are you sure you want to delete {category.CategoryName}?");
            //if (confirmed)
            //{
            //Categories.Remove(category);
            //}
        }
        public void onConfirm()
        {
            Categories.Remove(CategoryToBeDeleted);
            confirmation.Hide();
            CategoryToBeDeleted = null;
        }
        public void onCancel()
        {
            confirmation.Hide();
            CategoryToBeDeleted = null;
        }
    }
}
