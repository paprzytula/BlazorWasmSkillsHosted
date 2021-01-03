using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Shared
{
    public partial class InputImg
    {
        [Parameter] public string Label { get; set; } = "Image";
        [Parameter] public EventCallback<string> OnSelectedImage { get; set; }
        [Parameter] public string ImageUrl { get; set; }
        private string imageBase64;
        async  Task OnChange(InputFileChangeEventArgs e)
        {
            var imageFiles = e.GetMultipleFiles();
            foreach (var imageFile in imageFiles)
            {
                var buffer = new byte[imageFile.Size];
                await imageFile.OpenReadStream().ReadAsync(buffer);
                imageBase64 = Convert.ToBase64String(buffer);
                await OnSelectedImage.InvokeAsync(imageBase64);
                ImageUrl = null;
                StateHasChanged();
            }
        }
    }
}
