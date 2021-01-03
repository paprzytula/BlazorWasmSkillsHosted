using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages.Categories
{
    public partial class CategoryFilter
    {
        string title = "";
        string selectedCategory = "0";
        private List<Category> categories = new List<Category>();
        private void TitleKeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                Console.WriteLine("Enter pressed");
            }
        }


    }
}
