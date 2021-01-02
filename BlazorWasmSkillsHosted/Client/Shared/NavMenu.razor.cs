using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Shared
{
    public partial class NavMenu
    {
       
    private bool collapseNavMenu { get; set; } = true;

        private string NavMenuCssClass  => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}

