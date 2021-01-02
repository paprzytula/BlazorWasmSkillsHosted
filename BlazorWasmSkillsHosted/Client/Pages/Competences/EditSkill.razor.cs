using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages.Competences
{
    public partial class EditSkill
    {
        [Parameter] public int SkillId { get; set; }
        [Parameter] public string SkillName { get; set; }
        [Parameter] public int Value { get; set; }
    }
}
