using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages.Skills
{
    public partial class EditSkill
    {
        [Parameter] public int SkillId { get; set; }
        [Parameter] public string SkillName { get; set; }
        public Skill skill;
        protected override void OnInitialized()
        {
            skill = new Skill() { Id=SkillId, SkillName= "Speech", SkillCategory="Supervising", SkillDescription="Speech at some level is required for the leader"};
        }
        private void Edit()
        {

            Console.WriteLine("Edit method");
            Console.WriteLine($"Id = {skill.Id}");
            Console.WriteLine($"Category = {skill.SkillCategory}");
            Console.WriteLine($"Name = {skill.SkillName}");
            Console.WriteLine($"Description = {skill.SkillDescription}");
        }
    }
}
