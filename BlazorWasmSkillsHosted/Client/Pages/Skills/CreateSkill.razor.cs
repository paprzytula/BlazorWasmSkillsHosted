using BlazorWasmSkillsHosted.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages.Skills
{
    public partial class CreateSkill
    {
        Skill skill = new Skill();
        private void Create()
        {
            Console.WriteLine(skill.SkillName);
        }
    }
}
