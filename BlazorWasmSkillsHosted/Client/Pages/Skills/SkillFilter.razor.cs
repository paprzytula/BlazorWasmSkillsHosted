using BlazorWasmSkillsHosted.Client.Helpers;
using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages.Skills
{
    public partial class SkillFilter
    {
        string title;
        string selectedCategory = "0";
        string selectedDepartment = "0";
        private List<Category> categories;
        private List<Department> departments;
        private List<Skill> skills = new List<Skill>() { new Skill() { SkillName = "C#", SkillLevel = 2 } };
        bool one = false;
        bool two = false;
        bool three = false;
        bool four = false;
        bool five = false;
        [Inject] IRepository Repository { get; set; }
        private void TitleKeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                SearchForSkills();
            }
        }

        private void SearchForSkills()
        {
            if (Repository.GetCategories() != null)
            {


                categories = Repository.GetCategories()
                    .Where(x => x.CategoryName.Contains(title))
                    .ToList();
                Console.WriteLine($"one: {one}");
                Console.WriteLine($"two: {two}");
                Console.WriteLine($"selectedCategory: {selectedCategory}");
                Console.WriteLine($"selectedDepartment: {selectedDepartment}");
            }
        }
        private void Clear()
        {
            title = "";
            one = false;
            two = false;
            three = false;
            four = false;
            five = false;
            selectedCategory = "0";
            selectedDepartment = "0";
            categories = Repository.GetCategories();

        }
        protected override void OnInitialized()
        {
            categories = Repository.GetCategories();
            departments = Repository.GetDepartments();
            skills = Repository.GetSkills();
        }

    }
}
