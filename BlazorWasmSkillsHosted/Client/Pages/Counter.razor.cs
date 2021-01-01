using BlazorWasmSkillsHosted.Client.Helpers;
using BlazorWasmSkillsHosted.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singletonService { get; set; }
        [Inject] TransientService transientService { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [CascadingParameter] public AppStyle AppStyle { get; set; }
        private List<Category> categories;
        protected override void OnInitialized()
        {
            categories = new List<Category>()
{
        new Category()
        {
            Id = 2,
            CategoryName = "Shopfloor",

        },
        new Category()
        {
            Id = 3,
            CategoryName = "Programming"
        } };


        }

        private int currentCount = 0;
        private static int currentCountStatic = 0;
        IJSObjectReference module;
        [JSInvokable]
        public async Task IncrementCount()
        {
            module = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await module.InvokeVoidAsync("displayAlert", "hello from isolated JavaScript");
            currentCount++;
            transientService.Value += 1;
            singletonService.Value += 1;
            currentCountStatic++;
          await  js.InvokeVoidAsync("dotnetStaticInvokation");
        }
        private async Task IncrementCountJavaScript()
        {
            await js.InvokeVoidAsync("dotnetInstanceInvocation", DotNetObjectReference.Create(this));
        }
        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }

    }
}
