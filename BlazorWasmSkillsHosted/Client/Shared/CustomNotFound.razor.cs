using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Shared
{
    public partial class CustomNotFound
    {
        protected override void OnInitialized()
        {
            Console.WriteLine("404 NOT FOUND");
        }
    }
}
