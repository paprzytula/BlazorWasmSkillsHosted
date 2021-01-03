using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorWasmSkillsHosted.Client.Helpers;
using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace BlazorWasmSkillsHosted.Client.Shared
{
    public partial class MultipleSelector
    {
        private string removeAllText = "<<";
        private string addAllText = ">>";

        [Parameter] public List<MultipleSelectorModel> NotSelected { get; set; } = new List<MultipleSelectorModel>();
        [Parameter] public List<MultipleSelectorModel> Selected { get; set; } = new List<MultipleSelectorModel>();
        private void Select(MultipleSelectorModel item)
        {
            NotSelected.Remove(item);
            Selected.Add(item);
        }
        private void Deselect(MultipleSelectorModel item)
        {
            Selected.Remove(item);
            NotSelected.Add(item);
        }
        private void SelectAll()
        {
            Selected.AddRange(NotSelected);
            NotSelected.Clear();
        }
        private void DeselectAll()
        {
            NotSelected.AddRange(Selected);
            Selected.Clear();
        }
    }
}
