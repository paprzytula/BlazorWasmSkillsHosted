using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Shared
{
    public partial class Confirmation
    {
 
        [Parameter] public string Title { get; set; } = "Confirm";
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public EventCallback OnConfirm { get; set; }
        [Parameter] public EventCallback OnCancel  { get; set; }
        private bool DisplayConfirmation { get; set; } = false;
        public void Show() => DisplayConfirmation = true;
        public void Hide() => DisplayConfirmation = false;

    }
}
