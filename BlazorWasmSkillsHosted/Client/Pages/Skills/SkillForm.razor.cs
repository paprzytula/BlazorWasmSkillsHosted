using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages.Skills
{
    public partial class SkillForm
    {
        [Parameter] public Skill Skill { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
